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
            if (CollectionDirectoryTextBox.Text == "Insert Index Directory")
            {
                CollectionDirectoryTextBox.Text = "";

                CollectionDirectoryTextBox.ForeColor = Color.Black;
            }
        }

        private void IndexDirectoryTextBox_Leave(object sender, EventArgs e)
        {
            if (CollectionDirectoryTextBox.Text == "")
            {
                CollectionDirectoryTextBox.Text = "Insert Index Directory";

                CollectionDirectoryTextBox.ForeColor = Color.Silver;
            }
        }
        private void IndexDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CollectionPathTextBox = IndexDirectoryTextBox.Text;
            this.documentPath = CollectionPathTextBox;
        }

        
    }
}