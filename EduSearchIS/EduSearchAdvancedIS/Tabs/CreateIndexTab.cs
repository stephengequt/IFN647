using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSearchAdvancedIS
{
    public partial class CreateIndexTab : UserControl
    {
        private static CreateIndexTab _instance;
        public static CreateIndexTab Instance => _instance ?? (_instance = new CreateIndexTab());

        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();

        private string _collectionPathTextBox; //This variable is to store the Collection directory enter by user.
        private string _indexPathTextBox; //This variable is to store the Index directory enter by user.

        // source collection
        private string DocumentPath { get; set; } = @"..\..\..\collection\crandocs";
        public string IndexPath { get; set; } = @"..\..\..\assessment2Index";
        public bool indexChanged { get; set; } = false;
        public CreateIndexTab()
        {
           
            InitializeComponent();
        }

        private void CreateIndexTab_Load(object sender, EventArgs e)
        {
//            _indexPathTextBox = IndexDirectoryTextBox.Text;
//            this.IndexPath = _indexPathTextBox;
        }

        private void CollectionDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            this._collectionPathTextBox = this.CollectionDirectoryTextBox.Text;
            this.DocumentPath = _collectionPathTextBox;
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            CollectionDirectoryTextBox.Text = folderToReadLocation.SelectedPath;
            this.DocumentPath = folderToReadLocation.SelectedPath;
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {
            folderToReadLocation.ShowDialog();
            IndexDirectoryTextBox.Text = folderToReadLocation.SelectedPath;
        }

        private void CreateIndexButton_Click(object sender, EventArgs e)
        {
            List<string> fileList = LuceneAdvancedSearchApplication.WalkDirectoryTree(this.DocumentPath);

            // Check if there is any file for indexing
            if (fileList.Count == 0)
            {
                Console.WriteLine("Can't find any files in this directory.");
            }
            else
            {
                DateTime startIndexTime = System.DateTime.Now;

                this.myLuceneApp.CreateIndex(this.IndexPath);

                System.Console.WriteLine("Adding Documents to Index" + fileList.Count);
                foreach (string s in fileList)
                {
                    // System.Console.WriteLine("Adding doc " + docID + "to Index");
                    this.myLuceneApp.IndexText(s);
                    //                this.myLuceneApp.In
                }

                //Time for indexing
                DateTime endIndexTime = System.DateTime.Now;
                System.Console.WriteLine("All documents added, indexing time: {0}", endIndexTime - startIndexTime);
                TimeLabelToIndex.Text = (endIndexTime - startIndexTime).ToString();
                myLuceneApp.CleanUpIndexer();
                indexChanged = true;
            }
        }
    }
}
