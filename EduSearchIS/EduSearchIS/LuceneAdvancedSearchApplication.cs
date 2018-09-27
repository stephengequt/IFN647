using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;

namespace EduSearchIS
{
    class LuceneAdvancedSearchApplication
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        Similarity newSimilarity;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";


        public LuceneAdvancedSearchApplication()
        {
            luceneIndexDirectory = null;
            writer = null;
            analyzer = new Lucene.Net.Analysis.WhitespaceAnalyzer();
            //analyzer = new Lucene.Net.Analysis.SimpleAnalyzer(); // Activity 5
            //analyzer = new Lucene.Net.Analysis.StopAnalyzer(); // Activity 5
            //analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30); // Activity 5
            //analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English"); // Activity 7


            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            //newSimilarity = new NewSimilarity(); // Activity 9

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
            //writer.SetSimilarity(newSimilarity); // Activity 9
        }


        /// <summary>
        /// Indexes a given string into the index
        /// </summary>
        /// <param name="text">The text to index</param>
        public void IndexText(string text)
        {
            Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.YES);
            Lucene.Net.Documents.Document doc = new Document();
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
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
            //searcher.Similarity = newSimilarity; // Activity 9
        }

        /// <summary>
        /// Searches the index for the querytext
        /// </summary>
        /// <param name="querytext">The text to search the index</param>
        public void SearchText(string querytext)
        {

            System.Console.WriteLine("Searching for " + querytext);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            

            TopDocs results = searcher.Search(query, 100);
            
            // Display the number of results
            System.Console.WriteLine("Number of results is " + results.TotalHits);
             int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                // Console.WriteLine("Rank " + rank + " score " + scoreDoc.Score + " text " + myFieldValue); // Activity 8
//                Console.WriteLine("Rank " + rank + " text " + myFieldValue);
                Console.WriteLine("Rank " + rank);
                //Console.WriteLine("Content " + myFieldValue );
                OutputSections(myFieldValue);
                //Explanation e = searcher.Explain(query, scoreDoc.Doc); // Activity 8
                //System.Console.WriteLine(e.ToString());

            }

//            Console.WriteLine(DisplayFinialQuery(query)); //Test display final query

            var continueVal = false;
            var pageIndex = 0;
            do
            {
                var operation = Console.ReadLine();
                if (operation != "end")
                {
                    switch (operation)
                    {
                        case "next":
                            pageIndex++;
                            ResultBrowser(results.ScoreDocs, pageIndex);
                            Console.WriteLine();
                            break;
                        case "previous":
                            pageIndex--;
                            ResultBrowser(results.ScoreDocs, pageIndex);
                            Console.WriteLine();
                            break;
                        default:
                            ResultBrowser(results.ScoreDocs, pageIndex);
                            break;
                    }
                }
                else
                {
                    continueVal = true;
                }
                
            } while (continueVal == false);

        }

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }

        public static string[] SeparateString(string text)
        {
            string[] sections = text.Split(new string[] { ".I", ".T", ".A", ".B", ".W" }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var word in words)
            //Console.WriteLine(word);
            return sections;
        }

        public static void OutputSections(string str)
        {
            // Console.WriteLine("Tokens: ");
            string[] sections = SeparateString(str);

            //remove the title from the chunk of text
            sections[4] = sections[4].Replace(sections[1], "");

            //obtain the first line of text as the abstract
            var firstLine = sections[4].Split('.')[0];

            //outout the paper information with appropriate headings
            Console.WriteLine("Document ID:" + sections[0]);
            Console.WriteLine("Title: " + sections[1]);
            Console.WriteLine("Author: " + sections[2]);
            Console.WriteLine("Bibliographic Information: " + sections[3]);
            Console.WriteLine("Abstract: " + firstLine);
            //foreach (string s in sections)
            //{
            //    System.Console.WriteLine(s);
            //}
        }
    }
}
