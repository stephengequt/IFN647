using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syn.WordNet;

namespace EduSearchAdvancedIS.Tabs
{
    public partial class SearchTab : UserControl
    {
        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();
        public string IndexPath { get; set; } = @"..\..\..\assessment2Index";
        //        private  SearchTab _instance;

        //        public  SearchTab Instance => _instance ?? (_instance = new SearchTab(IndexPath));

        private string SelectedSearchField;
        int maxPageNum = 0;
        private int pageNum = 1;
        private DocInfo[] docList;
        private int selectedDocIndex;
        public string TopicId { get; set; }
        public bool TopicIdChanged { get; set; }


        public SearchTab(string indexPath)
        {
            InitializeComponent();
            this.IndexPath = indexPath;
            this.TopicIdChanged = false;
        }

        private void SearchTab_Load(object sender, EventArgs e)
        {

        }

//        private void SearchButton_Click(object sender, EventArgs e)
//        {
//            
//        }

        private void SelectField_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedSearchField = SelectField.SelectedItem.ToString();
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
                table = LuceneAdvancedSearchApplication.ViewCurrenPage(table, this.docList, pageNum);
                dataGridView1.DataSource = table;
            }
            else
            {
                PreviousButton.Enabled = false;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNum < maxPageNum)
            {
                pageNum++;
                PageNumLabel.Text = pageNum.ToString();
                PreviousButton.Enabled = true;

                //loadDataViewGrid();
                DataTable table = new DataTable();

                if (this.docList.Length == 0)
                {
                    Console.WriteLine("No result.");
                }
                else if (this.pageNum == this.maxPageNum)
                {
                    table = LuceneAdvancedSearchApplication.ViewLastPage(table, this.docList, this.pageNum);
                    NextButton.Enabled = false;
                }
                else
                {
                    table = LuceneAdvancedSearchApplication.ViewCurrenPage(table, this.docList, this.pageNum);
                }

                dataGridView1.DataSource = table;
            }
        }

        private void AbstractButton_Click(object sender, EventArgs e)
        {
            var selectedDocInfo = LuceneAdvancedSearchApplication.ViewSelectedDocInfo(this.docList, selectedDocIndex);
            MessageBox.Show((string)selectedDocInfo.Abstract, selectedDocInfo.Title);
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string query = QueryBox.Text;
            PreviousButton.Enabled = false;

            if (query == "Enter Query")
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "Search box is empty";
            }
            else
            {
                // Searching Code
                DateTime startSearchTime = System.DateTime.Now;
                if (string.IsNullOrEmpty(this.IndexPath))
                {
                    MessageBox.Show("Please select index directory first!", "Error");
                }
                else
                {
                    myLuceneApp.CreateSearcher(this.IndexPath);

                    //Perform query expansion by connecting to NetWord
                    if (this.myLuceneApp.QueryExpansionOpt)
                    {
                        // Firstly, return token based on query text
                        char[] delims = { ' ', '\n', '.', '\"' };
                        string[] words = query.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in words)
                        {
                            query += myLuceneApp.QueryExpansionByNetWord(word, this.myLuceneApp.wordNet);
                        }
                    }

                    SearchResult searchResult = myLuceneApp.SearchText(query, this.SelectedSearchField);

                    // Time for searching
                    DateTime endSearchTime = System.DateTime.Now;
                    var searchTime = endSearchTime - startSearchTime;
                    TimeTakenToSearch.Text = searchTime.ToString();

                    NumOfResultText.Text = searchResult.NumOfResult.ToString();
                    FinalQueryTextBox.Text = searchResult.finalQuery;
                    this.maxPageNum = Convert.ToInt32(searchResult.NumOfResult / 10) + 1;
                    if (maxPageNum > 10)
                    {
                        maxPageNum = 10;
                    }

                    this.docList = searchResult.DocInfoList.ToArray();
                    //                Console.WriteLine("Searching time: {0}", endSearchTime - startSearchTime);
                    myLuceneApp.CleanUpSearcher();

                    // Populate here with the codes to display the top 10 result
                    DataTable table = new DataTable();

                    if (this.docList.Length == 0)
                    {
                        Console.WriteLine("No result.");
                    }
                    else if (this.pageNum == this.maxPageNum)
                    {
                        table = LuceneAdvancedSearchApplication.ViewLastPage(table, this.docList, this.pageNum);
                    }
                    else
                    {
                        table = LuceneAdvancedSearchApplication.ViewCurrenPage(table, this.docList, this.pageNum);
                    }

                    dataGridView1.DataSource = table;
                    TotalPageLabel.Text = "out of " + this.maxPageNum.ToString();
                }
            }
        }

        private void PreprocessingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.myLuceneApp.PreProcessOpt = !PreprocessingCheckBox.Checked;
        }

        private void QueryExpansionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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

                Console.WriteLine("Loading WordNet database....");
                this.myLuceneApp.wordNet.Load();
                Console.WriteLine("WordNet Loaded.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryFileDirectory.Text = @"..\..\..\collection\cran_information_needs.txt";
            string content = LuceneAdvancedSearchApplication.OutputFileContent(QueryFileDirectory.Text);
            string[] sections = LuceneAdvancedSearchApplication.SeparateQueryString(content);
            QueryInfo[] queryInfos = LuceneAdvancedSearchApplication.GetQueryInfo(sections);
            foreach (var queryInfo in queryInfos)
            {
                var row = new string[] { queryInfo.QueryID, queryInfo.QueryContent };
                var listViewItem = new ListViewItem(row);
                //                listViewItem.Tag = queryInfo;
                QueryListView.Items.Add(listViewItem);
            }
        }

        private void QueryListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var subItem1 = e.Item.SubItems[0].Text;
            var subItem2 = e.Item.SubItems[1].Text;
            QueryBox.Text = subItem2;
            TopicId = subItem1;
            TopicIdChanged = true;
        }
    }
}
