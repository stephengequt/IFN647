using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Support;
using Lucene.Net.Util;
//using SpellChecker.Net.Search.Spell;
using Syn.WordNet;

namespace EduSearchAdvancedIS
{
    class LuceneAdvancedSearchApplication
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        Similarity customizedSimilarity;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;

        private const string TEXT_FN = "Full text";
        private const string TITLE_FN = "Title";
        private const string AUTHOR_FN = "Author";
        private const string BIB_FN = "Bib";
        private const string ABS_FN = "Abs";

        public bool PreProcessOpt { get; set; } = true;
        public bool QueryExpansionOpt { get; set; }
        public WordNetEngine wordNet { get; set; }


        public LuceneAdvancedSearchApplication()
        {
            luceneIndexDirectory = null;
            writer = null;
//            analyzer = new Lucene.Net.Analysis.WhitespaceAnalyzer();
//            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer(); 
//            analyzer = new Lucene.Net.Analysis.StopAnalyzer(Lucene.Net.Util.Version.LUCENE_30); 
//            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30,
                "English");

            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            customizedSimilarity = new CustomizedSimilarity();
        }


        /// <summary>
        /// Creates the index at a given path
        /// </summary>
        /// <param name="indexPath">The pathname to create the index</param>
        public void CreateIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
            writer.SetSimilarity(customizedSimilarity);
        }


        /// <summary>
        /// Indexes a given string into the index
        /// </summary>
        /// <param name="text">The text to index</param>
        public void IndexText(string text)
        {
            DocInfo docInfo = OutputSections(text);
            Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED,
                Field.TermVector.YES);
            // Add field Author
            Lucene.Net.Documents.Field docAuthorField = new Field(AUTHOR_FN, docInfo.Author, Field.Store.YES,
                Field.Index.ANALYZED, Field.TermVector.YES);
            // Add field Title
            Lucene.Net.Documents.Field docTitleField = new Field(TITLE_FN, docInfo.Title, Field.Store.YES,
                Field.Index.ANALYZED, Field.TermVector.YES);
            //Add field Bibliography
            Lucene.Net.Documents.Field docBibliographyField = new Field(BIB_FN, docInfo.Bibliography, Field.Store.YES,
                Field.Index.ANALYZED, Field.TermVector.YES);
            //Add field Abstract
            Lucene.Net.Documents.Field docAbstractField = new Field(ABS_FN, docInfo.Abstract, Field.Store.YES,
                Field.Index.ANALYZED, Field.TermVector.YES);

            Lucene.Net.Documents.Document doc = new Document();
            // Add all the fields into index
            doc.Add(docAuthorField);
            doc.Add(docTitleField);
            doc.Add(docBibliographyField);
            doc.Add(docAbstractField);
            doc.Add(field);
            writer.AddDocument(doc);
        }


        /// <summary>
        /// Flushes the buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }


        /// <summary>
        /// Creates the searcher object
        /// </summary>
        public void CreateSearcher(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);

            searcher = new IndexSearcher(luceneIndexDirectory) {Similarity = customizedSimilarity};
        }

        /// <summary>
        /// Searches the index for the querytext
        /// </summary>
        /// <param name="querytext">The text to search the index</param>
        public SearchResult SearchText(string querytext, string searchField, bool ifTitleBoost, bool ifAuthorBoost,
            decimal titleBoostNum, decimal authorBoostNum)
        {
            System.Console.WriteLine("Searching for " + querytext);
            querytext = querytext.ToLower();
            // Pre-processing option
            if (!PreProcessOpt)
            {
                querytext = "\"" + querytext + "\"";
            }


            Query query = null;
            if (ifAuthorBoost || ifTitleBoost)
            {
                string[] fields = {TITLE_FN, AUTHOR_FN, BIB_FN, ABS_FN};

                HashMap<string, float> boosts = new HashMap<string, float>();

                // Title boosting
                if (ifTitleBoost)
                {
                    boosts.Add(TITLE_FN, Convert.ToSingle(titleBoostNum));
                }

                // Author boosting
                if (ifAuthorBoost)
                {
                    boosts.Add(AUTHOR_FN, Convert.ToSingle(authorBoostNum));
                }

                // boosting with built-in boost function
                MultiFieldQueryParser queryParser = new MultiFieldQueryParser(VERSION, fields, analyzer, boosts);
                query = queryParser.Parse(querytext);
            }
            else
            {
                query = parser.Parse(querytext);
            }


            TopDocs results = searcher.Search(query, 100);

            int rank = 0;
            List<DocInfo> scoreDocList = new List<DocInfo>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                var docContent = searcher.Doc(scoreDoc.Doc);
                var field_value = docContent.Get(TEXT_FN).ToString();
                var docInfo = OutputSections(field_value);
                docInfo.Rank = rank;
                docInfo.DocScore = scoreDoc.Score;

                scoreDocList.Add(docInfo);
            }

            // Save all the search result into SearchResult pbject
            SearchResult searchResult = new SearchResult
            {
                NumOfResult = results.TotalHits,
                DocInfoList = scoreDocList,
                finalQuery = query.ToString()
            };
            return searchResult;
        }

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }

        /// <summary>
        /// Separate sections in original doc
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string[] SeparateDocString(string text)
        {
            string[] sections = text.Split(new string[] {".I", ".T", ".A", ".B", ".W"}, StringSplitOptions.None);
            return sections;
        }

        /// <summary>
        /// Separate section in information needs
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string[] SeparateQueryString(string text)
        {
            string[] sections = text.Split(new string[] {".I ", ".D"}, StringSplitOptions.RemoveEmptyEntries);
            return sections;
        }

        /// <summary>
        /// Get query information
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static QueryInfo[] GetQueryInfo(string[] sections)
        {
            List<QueryInfo> queryInfos = new List<QueryInfo>();
            for (int i = 0; i < sections.Length / 2 - 1; i++)
            {
                QueryInfo queryInfo = new QueryInfo()
                {
                    QueryID = sections[2 * i],
                    QueryContent = sections[2 * i + 1]
                };
                queryInfos.Add(queryInfo);
            }

            return queryInfos.ToArray();
        }

        /// <summary>
        /// formatting original doc
        /// </summary>
        /// <param name="docContent"></param>
        /// <returns></returns>
        public static DocInfo OutputSections(string docContent)
        {
            string[] sections = SeparateDocString(docContent);

            //remove the title from the chunk of text
            if (!string.IsNullOrEmpty(sections[2]))
            {
                sections[5] = sections[5].Replace(sections[2], null);
            }

            //obtain the first line of text as the abstract
            var firstLine = sections[5].Split('.')[0];

            DocInfo docInfo = new DocInfo
            {
                DocID = sections[1],
                Title = sections[2],
                Author = sections[3],
                Bibliography = sections[4],
                Sentence = firstLine.Trim(),
                Abstract = sections[5].Trim()
            };

            return docInfo;
        }

        /// <summary>
        /// Read file content
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string OutputFileContent(string name)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(name);
            string text = "";
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                text += line;
            }

            reader.Close();

            return text;
        }

        // Read files in directory
        public static List<string> WalkDirectoryTree(String path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder 
            try
            {
                // filter the file
                files = root.GetFiles("*.txt");
            }

            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            List<string> fileList = new List<string>();

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    string name = fi.FullName;
                    fileList.Add(OutputFileContent(name));
                }
            }

            return fileList;
        }

        /// <summary>
        /// View search result of current page
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="docList"></param>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        public static DataGridView ViewCurrentPage(DataGridView dataGridView, DocInfo[] docList, int pageNum)
        {
            var pageIndex = pageNum - 1;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Visible = false;
            }

            for (int i = 0 + pageIndex * 10; i < 10 + pageIndex * 10; i++)
            {
                dataGridView.Rows[i].Visible = true;
            }

            return dataGridView;
        }

        /// <summary>
        /// handle exceptions when the items in the last page is less then 10
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="docList"></param>
        /// <param name="pageNum"></param>
        /// <returns></returns>
        public static DataGridView ViewLastPage(DataGridView dataGridView, DocInfo[] docList, int pageNum)
        {
            var pageIndex = pageNum - 1;

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Visible = false;
            }


            for (int i = 0 + pageIndex * 10; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Visible = true;
            }

            return dataGridView;
        }

        /// <summary>
        /// View Doc information, for view abstract purpose
        /// </summary>
        /// <param name="docList"></param>
        /// <param name="selectedDocIndex"></param>
        /// <returns></returns>
        public static DocInfo ViewSelectedDocInfo(DocInfo[] docList, int selectedDocIndex)
        {
            DocInfo selectedDoc = docList[selectedDocIndex];

            return selectedDoc;
        }

        /// <summary>
        /// Query expansion by using Wordnet
        /// </summary>
        /// <param name="word"></param>
        /// <param name="wordNet"></param>
        /// <returns></returns>
        public string QueryExpansionByWordNet(string word, WordNetEngine wordNet)
        {
            var synSetList = wordNet.GetSynSets(word);

            if (synSetList.Count == 0)
            {
                return " ";
            }

            string wordExpansionWithoutOriginalWord = null;

            foreach (var synSet in synSetList)
            {
                List<string> synSetWordWithoutOriginalWord = new List<string>();
                foreach (var synSetWord in synSet.Words)
                {
                    if (synSetWord != word || !synSetWordWithoutOriginalWord.Contains(synSetWord.ToLower()))
                    {
                        synSetWordWithoutOriginalWord.Add(synSetWord);
                    }
                }

                wordExpansionWithoutOriginalWord += " " + string.Join(" ", synSetWordWithoutOriginalWord);
            }

            return wordExpansionWithoutOriginalWord;
        }
    }
}