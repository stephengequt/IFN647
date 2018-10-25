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

        public GUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            IndexLabel.Text = folderToReadLocation.SelectedPath;
            this.documentPath = folderToReadLocation.SelectedPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            CollectionLabel.Text = folderToReadLocation.SelectedPath;
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
    }
}