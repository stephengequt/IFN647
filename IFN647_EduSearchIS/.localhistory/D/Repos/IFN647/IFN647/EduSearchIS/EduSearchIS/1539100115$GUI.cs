using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using Lucene.Net.Documents;
using System.IO;

namespace EduSearchIS

{
    public partial class GUI : Form
    {
        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();

        DataTable table = new DataTable();
        // source collection

        static string stephenPath =
            @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection\crandocs";

        static string soamPath = @"C:\Users\svege\Dropbox\Master sem 4\IR\Assignment\crandocs";

        string aaronPath =
            @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection\crandocs";

        static string stephenIndexPath =
            @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\assessment2Index";

        static string soamIndexPath = @"C:\Users\svege\Dropbox\Master sem 4\IR\Assignment\GUI";
        private string documentPath = stephenPath;
        private string IndexPath = stephenIndexPath;
        private string CollectionPathTextBox; //This variable is to store the Collection directory enter by user.
        private string IndexPathTextBox; //This variable is to store the Index directory enter by user.
        private int pageNum = 1;
        int maxPageNum = 0;
        private DocInfo[] docList;
        private int selectedDocIndex;


        public GUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            IndexDirectoryTextBox.Text = folderToReadLocation.SelectedPath;
//            this.documentPath = folderToReadLocation.SelectedPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            CollectionDirectoryTextBox.Text = folderToReadLocation.SelectedPath;
            this.documentPath = folderToReadLocation.SelectedPath;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void CreateIndexButton_Click(object sender, EventArgs e)
        {
            List<string> fileList = Program.WalkDirectoryTree(this.documentPath);

            DateTime startIndexTime = System.DateTime.Now;

            this.myLuceneApp.CreateIndex(this.IndexPath);

            System.Console.WriteLine("Adding Documents to Index" + fileList.Count);
            int docID = 0;
            foreach (string s in fileList)
            {
                // System.Console.WriteLine("Adding doc " + docID + "to Index");
                this.myLuceneApp.IndexText(s);
                docID++;
            }

            //Time for indexing
            DateTime endIndexTime = System.DateTime.Now;
            System.Console.WriteLine("All documents added, indexing time: {0}", endIndexTime - startIndexTime);
            TimeLabelToIndex.Text = (endIndexTime - startIndexTime).ToString();
            myLuceneApp.CleanUpIndexer();
        }

        private void CollectionDirectoryTextBox_Enter(object sender, EventArgs e)
        {
            if (CollectionDirectoryTextBox.Text == "Insert Collection Directory")
            {
                CollectionDirectoryTextBox.Text = "";

                CollectionDirectoryTextBox.ForeColor = Color.Black;
            }
        }

        private void CollectionDirectoryTextBox_Leave(object sender, EventArgs e)
        {
            if (CollectionDirectoryTextBox.Text == "")
            {
                CollectionDirectoryTextBox.Text = "Insert Collection Directory";

                CollectionDirectoryTextBox.ForeColor = Color.Silver;
            }
        }

        private void CollectionDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CollectionPathTextBox = CollectionDirectoryTextBox.Text;
            this.documentPath = CollectionPathTextBox;
        }

        private void IndexDirectoryTextBox_Enter(object sender, EventArgs e)
        {
            if (IndexDirectoryTextBox.Text == "Insert Index Directory")
            {
                IndexDirectoryTextBox.Text = "";

                IndexDirectoryTextBox.ForeColor = Color.Black;
            }
        }

        private void IndexDirectoryTextBox_Leave(object sender, EventArgs e)
        {
            if (IndexDirectoryTextBox.Text == "")
            {
                IndexDirectoryTextBox.Text = "Insert Index Directory";

                IndexDirectoryTextBox.ForeColor = Color.Silver;
            }
        }

        private void IndexDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            IndexPathTextBox = IndexDirectoryTextBox.Text;
            this.IndexPath = IndexPathTextBox;
        }

        private void QueryBox_Enter(object sender, EventArgs e)
        {
            if (QueryBox.Text == "Enter Query")
            {
                QueryBox.Text = "";

                QueryBox.ForeColor = Color.Black;
            }
        }

        private void QueryBox_Leave(object sender, EventArgs e)
        {
            if (QueryBox.Text == "")
            {
                QueryBox.Text = "Enter Query";

                QueryBox.ForeColor = Color.Silver;
            }
        }

        private void QueryBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void TimeLabelToIndex_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            this.selectedDocIndex = 10 * (pageNum - 1) + index;
        }


        private void SearchButton_Click(object sender, EventArgs e)
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
                myLuceneApp.CreateSearcher();

//            var query =
//                "what \"similarity laws\" must be obeyed when constructing aeroelastic models of heated high speed aircraft";

                //SearchResult searchResult = myLuceneApp.SearchText(query);
                SearchResult searchResult = myLuceneApp.SearchText(query);

                // Time for searching
                DateTime endSearchTime = System.DateTime.Now;
                var searchTime = endSearchTime - startSearchTime;
                TimeTakenToSearch.Text = searchTime.ToString();

                NumOfResultText.Text = searchResult.NumOfResult.ToString();
                FinalQueryText.Text = searchResult.finalQuery;
                this.maxPageNum = Convert.ToInt32(searchResult.NumOfResult / 10) + 1;

                this.docList = searchResult.DocInfoList.ToArray();
//                Console.WriteLine("Searching time: {0}", endSearchTime - startSearchTime);
                myLuceneApp.CleanUpSearcher();

                // Populate here with the codes to display the top 10 result
                DataTable table = new DataTable();

                if (this.docList.Length == 0)
                {
                    Console.WriteLine("No result.");
                }
                else if (this.pageNum == this.maxPageNum - 1)
                {
                    table = Program.ViewLastPage(table, this.docList, this.pageNum);
                }
                else
                {
                    table = Program.ViewCurrenPage(table, this.docList, this.pageNum);
                }

                dataGridView1.DataSource = table;
                TotalPageLabel.Text = "out of " + this.maxPageNum.ToString();
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
                    table = Program.ViewLastPage(table, this.docList, this.pageNum);
                    NextButton.Enabled = false;
                }
                else
                {
                    table = Program.ViewCurrenPage(table, this.docList, this.pageNum);
                }

                dataGridView1.DataSource = table;
            }
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
                table = Program.ViewCurrenPage(table, this.docList, pageNum);
                dataGridView1.DataSource = table;
            }
            else
            {
                PreviousButton.Enabled = false;
            }
        }

        private void TopicIDBox_Enter(object sender, EventArgs e)
        {
            if (TopicIDBox.Text == "Enter Topic ID")
            {
                TopicIDBox.Text = "";

                TopicIDBox.ForeColor = Color.Black;
            }
        }

        private void TopicIDBox_Leave(object sender, EventArgs e)
        {
            if (TopicIDBox.Text == "")
            {
                TopicIDBox.Text = "Enter Topic ID";

                TopicIDBox.ForeColor = Color.Silver;
            }
        }

        private void TopicIDBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ResultDirectoryText_Enter(object sender, EventArgs e)
        {
            if (ResultDirectoryText.Text == "Insert Result Directory")
            {
                ResultDirectoryText.Text = "";

                ResultDirectoryText.ForeColor = Color.Black;
            }
        }

        private void ResultDirectoryText_Leave(object sender, EventArgs e)
        {
            if (ResultDirectoryText.Text == "")
            {
                ResultDirectoryText.Text = "Insert Result Directory";

                ResultDirectoryText.ForeColor = Color.Silver;
            }
        }

        private void BrowseResultButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ResultDirectoryText.Text = @"D:\result.text";
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            this.myLuceneApp.PreProcessOpt = !PreprocessingCheckBox.Checked;
        }

        private void TimeTakenToSearch_Click(object sender, EventArgs e)
        {
        }

        private void TotalPageLabel_Click(object sender, EventArgs e)
        {
        }

        private void AbstractButton_Click(object sender, EventArgs e)
        {
//            var selectedDocInfo = Program.ViewSelectedDocInfo(this.docList, selectedDocIndex);
//            MessageBox.Show(selectedDocInfo.Abstract, selectedDocInfo.Title);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (TopicIDBox.Text == "Enter Topic ID")
            {
                ResultMsg.ForeColor = Color.Red;
                ResultMsg.Text = "Topic ID is empty";
                //return;
            }

            else if (ResultDirectoryText.Text == "Insert Result Directory")
            {
                ResultMsg.ForeColor = Color.Red;
                ResultMsg.Text = "No file has been selected";
                //return;
            }

            else
            {
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                    {
                        foreach (DocInfo docInfo in this.docList)
                        {
                            sw.Write(TopicIDBox.Text);
                            sw.Write(" Q0 ");
                            sw.Write(docInfo.DocID);
                            sw.Write(" " + docInfo.Rank);
                            sw.Write(" " + docInfo.DocScore);
                            sw.WriteLine(" BaselineSystem");
                        }

                        ResultMsg.ForeColor = Color.Green;
                        ResultMsg.Text = "File has been created successfully";
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(saveFileDialog1.FileName))
                    {
                        foreach (DocInfo docInfo in this.docList)
                        {
                            sw.Write(TopicIDBox.Text);
                            sw.Write(" Q0 ");
                            sw.Write(docInfo.DocID);
                            sw.Write(" " + docInfo.Rank);
                            sw.Write(" " + docInfo.DocScore);
                            sw.WriteLine(" BaselineSystem");
                        }

                        ResultMsg.ForeColor = Color.Green;
                        ResultMsg.Text = "File has been updated successfully";
                    }
                }
            }
        }

        private void ResultDirectoryText_TextChanged(object sender, EventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void PreprocessingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.myLuceneApp.PreProcessOpt = !PreprocessingCheckBox.Checked;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingWindow settingWindow = new SettingWindow();
            settingWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit this program?", "Exit", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveResultWindow saveResultWindow = new SaveResultWindow();
            saveResultWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryFileDirectory.Text =
                @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection\cran_information_needs.txt";
            string content = Program.OutputFileContent(QueryFileDirectory.Text);
            string[] sections = LuceneAdvancedSearchApplication.SeparateQueryString(content);
            QueryInfo[] queryInfos = LuceneAdvancedSearchApplication.GetQueryInfo(sections);
            foreach (var queryInfo in queryInfos)
            {
                var row = new string[] {queryInfo.QueryID, queryInfo.QueryContent};
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = queryInfo;
                QueryListView.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var seletedQuery = QueryListView.SelectedItems[0].SubItems;
//                QueryBox.Text = seletedQuery[0];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}