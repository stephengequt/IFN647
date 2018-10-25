using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Syn.WordNet;
using SpellChecker = SpellChecker.Net.Search.Spell.SpellChecker;

namespace EduSearchAdvancedIS.Tabs
{
    public partial class SearchTab : UserControl
    {
        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();

        public string IndexPath { get; set; } = @"..\..\..\assessment2Index";
        private string SelectedSearchField;
        int maxPageNum = 0;
        private int pageNum = 1;
        private string finalQuery;
        public DocInfo[] docList { get; set; }
        private int selectedDocIndex;
        public string TopicId { get; set; }
        public string QueryText { get; set; }
        public string SearchTime { get; set; } = null;
        public string SpellCheckText { get; set; } = null;
        public bool TopicIdChanged { get; set; }


        public SearchTab(string indexPath)
        {
            InitializeComponent();
            this.IndexPath = indexPath;
            this.TopicIdChanged = false;
            PreviousButton.Enabled = false;
            FieldLevelBoostPanel.Enabled = false;
            TitleBoostNum.Enabled = false;
            AuthorboostNum.Enabled = false;
        }

        private void SearchTab_Load(object sender, EventArgs e)
        {
        }


        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum--;
                PageNumLabel.Text = pageNum.ToString();
                NextButton.Enabled = true;

                //loadDataViewGrid();
                DataTable table = new DataTable();
                dataGridView1 = LuceneAdvancedSearchApplication.ViewCurrentPage(dataGridView1, this.docList, pageNum);
//                dataGridView1.DataSource = table;
            }
            else
            {
                PreviousButton.Enabled = false;
            }
        }

        /// <summary>
        /// Next page button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNum < maxPageNum)
            {
                pageNum++;
                PageNumLabel.Text = pageNum.ToString();
                PreviousButton.Enabled = true;

                if (this.docList.Length == 0)
                {
                    Console.WriteLine("No result.");
                }
                else if (this.pageNum == this.maxPageNum)
                {
                    dataGridView1 =
                        LuceneAdvancedSearchApplication.ViewLastPage(dataGridView1, this.docList, this.pageNum);
                    NextButton.Enabled = false;
                }
                else
                {
                    dataGridView1 =
                        LuceneAdvancedSearchApplication.ViewCurrentPage(this.dataGridView1, this.docList, this.pageNum);
                }
            }
        }

        //View abstract
        private void AbstractButton_Click(object sender, EventArgs e)
        {
            var selectedDocInfo = LuceneAdvancedSearchApplication.ViewSelectedDocInfo(this.docList, selectedDocIndex);
            var contentFormat = "Title: " + selectedDocInfo.Title + "\n" + "\n" + "Author: " + selectedDocInfo.Author +
                                "\n" + "\n" +
                                "Abstrat: \n" + selectedDocInfo.Abstract;
            var titleFormat = "DocID: " + selectedDocInfo.DocID;
            MessageBox.Show((string) contentFormat, titleFormat);
        }

        // enable as-is function
        private void PreprocessingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.myLuceneApp.PreProcessOpt = !PreprocessingCheckBox.Checked;
        }

        // load wordnet library
        private void QueryExpansionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.FieldBoostCheckBox.Enabled = !QueryExpansionCheckBox.Checked;
            if (QueryExpansionCheckBox.Checked)
            {
                this.FieldBoostCheckBox.Checked = false;
            }

            this.myLuceneApp.QueryExpansionOpt = QueryExpansionCheckBox.Checked;
            if (this.myLuceneApp.QueryExpansionOpt)
            {
                string WordNet_Dir = @"..\..\..\WordNetDatabase";

                this.myLuceneApp.wordNet = new WordNetEngine();
                this.myLuceneApp.wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_Dir, "data.adj")),
                    PartOfSpeech.Adjective);
                this.myLuceneApp.wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_Dir, "data.adv")),
                    PartOfSpeech.Adverb);
                this.myLuceneApp.wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_Dir, "data.noun")),
                    PartOfSpeech.Noun);
                this.myLuceneApp.wordNet.AddDataSource(new StreamReader(Path.Combine(WordNet_Dir, "data.verb")),
                    PartOfSpeech.Verb);

                this.myLuceneApp.wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_Dir, "index.adj")),
                    PartOfSpeech.Adjective);
                this.myLuceneApp.wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_Dir, "index.adv")),
                    PartOfSpeech.Adverb);
                this.myLuceneApp.wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_Dir, "index.noun")),
                    PartOfSpeech.Noun);
                this.myLuceneApp.wordNet.AddIndexSource(new StreamReader(Path.Combine(WordNet_Dir, "index.verb")),
                    PartOfSpeech.Verb);

                this.myLuceneApp.wordNet.Load();
            }
        }

        // read information needs file
        private void button1_Click(object sender, EventArgs e)
        {
            QueryFileDirectory.Text = @"..\..\..\collection\cran_information_needs.txt";
            string content = LuceneAdvancedSearchApplication.OutputFileContent(QueryFileDirectory.Text);
            string[] sections = LuceneAdvancedSearchApplication.SeparateQueryString(content);
            QueryInfo[] queryInfos = LuceneAdvancedSearchApplication.GetQueryInfo(sections);
            foreach (var queryInfo in queryInfos)
            {
                var row = new string[] {queryInfo.QueryID, queryInfo.QueryContent};
                var listViewItem = new ListViewItem(row);
                //                listViewItem.Tag = queryInfo;
                QueryListView.Items.Add(listViewItem);
            }
        }

        // when selected index changed, get row infomation
        private void SelectField_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TopicId = e.Item.SubItems[0].Text;
            QueryText = e.Item.SubItems[1].Text;
            TopicIdChanged = true;
        }

        // Search function
        public void LuceneSearch(string query, bool spellCheckOpt)
        {
            DateTime startSearchTime = System.DateTime.Now;
            if (string.IsNullOrEmpty(this.IndexPath))
            {
                MessageBox.Show("Please select index directory first!", "Error");
            }
            else
            {
                dataGridView1.Rows.Clear();
                myLuceneApp.CreateSearcher(this.IndexPath);

                //Perform spell check
                if (spellCheckOpt)
                {
                    BingSpellCheck bingSpellCheck = new BingSpellCheck();

                    this.SpellCheckText = bingSpellCheck.SpellCheckCorrection(query);
                    query = this.SpellCheckText;
                }

                //Perform query expansion by connecting to NetWord
                if (this.myLuceneApp.QueryExpansionOpt)
                {
                    // Firstly, return token based on query text
                    char[] delims = {' ', '\n', '.', '\"'};
                    string[] originalQueryWords = query.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                    string weightedQuery = null;
                    foreach (var word in originalQueryWords)
                    {
                        string weightedWord = word + "^5";
                        weightedQuery += " " + weightedWord;
                    }

                    weightedQuery += " ";
                    foreach (var word in originalQueryWords)
                    {
                        weightedQuery += myLuceneApp.QueryExpansionByWordNet(word, this.myLuceneApp.wordNet);
                    }

                    query = weightedQuery;
                }

                //store search result in Search result object
                SearchResult searchResult = myLuceneApp.SearchText(query, this.SelectedSearchField,
                    TitleBoostCheckBox.Enabled, AuthorBoostCheckBox.Enabled, TitleBoostNum.Value, AuthorboostNum.Value);

                // Time for searching
                DateTime endSearchTime = System.DateTime.Now;
                this.SearchTime = (endSearchTime - startSearchTime).Milliseconds.ToString();

                NumOfResultText.Text = searchResult.NumOfResult.ToString();
                finalQuery = searchResult.finalQuery;
                this.maxPageNum = Convert.ToInt32(searchResult.NumOfResult / 10) + 1;
                if (maxPageNum > 10)
                {
                    maxPageNum = 10;
                }

                this.docList = searchResult.DocInfoList.ToArray();
                myLuceneApp.CleanUpSearcher();

                int rank = 1;

                foreach (var doc in docList)
                {
                    dataGridView1.Rows.Add(rank, doc.Title, doc.Author, doc.Bibliography,
                        doc.Sentence);
                    rank++;
                }

                if (this.docList.Length == 0)
                {
                    Console.WriteLine("No result.");
                }
                else if (this.pageNum == this.maxPageNum)
                {
                    dataGridView1 =
                        LuceneAdvancedSearchApplication.ViewLastPage(dataGridView1, this.docList, this.pageNum);
                }
                else
                {
                    dataGridView1 =
                        LuceneAdvancedSearchApplication.ViewCurrentPage(dataGridView1, this.docList, this.pageNum);
                }

                TotalPageLabel.Text = "out of " + this.maxPageNum.ToString();
            }

        }

        //read query file path
        private void button3_Click(object sender, EventArgs e)
        {
            FolderToRead.ShowDialog();
            QueryFileDirectory.Text = FolderToRead.SelectedPath;
            this.QueryFileDirectory.Text = FolderToRead.SelectedPath;
        }

        // Show final query
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((string) finalQuery, "Final Query");
        }

        
        private void FieldBoostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FieldLevelBoostPanel.Enabled = FieldBoostCheckBox.Checked;
            QueryExpansionCheckBox.Enabled = !FieldBoostCheckBox.Checked;

            if (FieldBoostCheckBox.Checked)
            {
                QueryExpansionCheckBox.Checked = false;
            }
        }

        private void TitleBoostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TitleBoostNum.Enabled = TitleBoostCheckBox.Checked;
        }

        private void AuthorBoostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AuthorboostNum.Enabled = AuthorBoostCheckBox.Checked;
        }

        private void QueryFileDirectory_TextChanged(object sender, EventArgs e)
        {
        }
    }
}