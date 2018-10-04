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

namespace EduSearchIS

{
    public partial class GUI : Form
    {
        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();
        DataTable dt = new DataTable();

        // source collection

        static string stephenPath =
            @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection\crandocs";

        string soamPath = @"C:\Users\svege\Dropbox\Master sem 4\IR\Assignment\crandocs";

        string aaronPath =
            @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection\crandocs";

        static string stephenIndexPath = @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\assessment2Index";
        private string documentPath = stephenPath;
        private string IndexPath = stephenIndexPath;
        private string CollectionPathTextBox; //This variable is to store the Collection directory enter by user.
        private string IndexPathTextBox; //This variable is to store the Index directory enter by user.
        private int pageNum = 1;
        private int pageSize = 20;
        int maxPageNum = 0;

        public GUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            IndexDirectoryTextBox.Text = folderToReadLocation.SelectedPath;
            this.documentPath = folderToReadLocation.SelectedPath;
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

            System.Console.WriteLine("Adding Documents to Index");
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

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (QueryBox.Text == "Enter Query")
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "Search box is empty";
            }

            // Populate here with the codes to display the top 10 result
            else
            {
                try
                {
                    myLuceneApp.CreateSearcher();
                }
                catch
                {
                    StatusLabel.ForeColor = Color.Green;
                    StatusLabel.Text = "YE";
                    return;
                }

                DataTable dtResult = myLuceneApp.DTResults(myLuceneApp.DTSearchText(QueryBox.Text, StatusLabel),this, this.dt);

                if (dtResult.Rows != null)
                {
                    if (dtResult.Rows.Count > 0)
                    {
                        pageNum = 1;
                        PageNumLabel.Text = pageNum.ToString();
                        loadDataViewGrid();
                        double temp = (double)dtResult.Rows.Count / (double)pageSize;
                        maxPageNum = (int)Math.Ceiling(temp);
                        TotalPageLabel.Text = "Out of  " + maxPageNum.ToString();
                        resultVisibleToggle(true);
                    }
                    else
                    {
                        dataGridView1.DataSource = dtResult;
                        StatusLabel.ForeColor = Color.Red;
                        StatusLabel.Text = "No results";
                        resultVisibleToggle(false);
                    }
                }
                else
                {
                    dataGridView1.DataSource = dtResult;
                    StatusLabel.ForeColor = Color.Red;
                    StatusLabel.Text = "No results";
                    resultVisibleToggle(false);
                }

                myLuceneApp.CleanUpSearcher();
            }
        }

        private void loadDataViewGrid()
        {
            DataTable emptyDt = new DataTable();
            dataGridView1.DataSource = emptyDt;
            DataTable dtPage = dt.Rows.Cast<System.Data.DataRow>().Skip((pageNum - 1) * pageSize).Take(pageSize).CopyToDataTable();
            dataGridView1.DataSource = dtPage;
            this.dataGridView1.Columns["Path"].Visible = false;
        }

        private void resultVisibleToggle(bool toggle)
        {
            if (toggle == true)
            {
                PreviousButton.Visible = true;
                dataGridView1.Visible = true;
                PageLabel.Visible = true;
                PageNumLabel.Visible = true;
                TotalPageLabel.Visible = true;
                NextButton.Visible = true;
            }
            else
            {
                PreviousButton.Visible = false;
                dataGridView1.Visible = false;
                PageLabel.Visible = false;
                PageNumLabel.Visible = false;
                TotalPageLabel.Visible = false;
                NextButton.Visible = false;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
     
            if (pageNum < maxPageNum)
            {
                pageNum++;
                PageNumLabel.Text = pageNum.ToString();

                //loadDataViewGrid();
            }
     
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum--;
                PageNumLabel.Text = pageNum.ToString();

                //loadDataViewGrid();
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

        private void BrowseResultButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}