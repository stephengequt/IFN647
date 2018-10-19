using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EduSearchAdvancedIS.Tabs;
using Syn.WordNet;

namespace EduSearchAdvancedIS

{
    public partial class MainWindow : Form
    {
        private bool mouseDown;
        private Point lastLocation;

//        LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();

        // source collection
        private string documentPath = @"..\..\..\collection\crandocs";
        public string IndexPath { get; set; } = @"..\..\..\assessment2Index";
        private static string defaultIndexPath = @"..\..\..\assessment2Index";

        private string CollectionPathTextBox; //This variable is to store the Collection directory enter by user.
        private string IndexPathTextBox; //This variable is to store the Index directory enter by user.
        private int pageNum = 1;
        int maxPageNum = 0;
        private DocInfo[] docList;
        private int selectedDocIndex;
        private string SelectedSearchField;

        CreateIndexTab _createIndexTab = new CreateIndexTab();
        SearchTab _searchTab = new SearchTab(defaultIndexPath);
        SaveResultTab _saveResultTab = new SaveResultTab(null, null);


        public MainWindow()
        {
            InitializeComponent();
            IndexMenu.BackColor = Color.FromArgb(237, 237, 237);
            IndexMenu.ForeColor = Color.FromArgb(99, 99, 99);

            SearchMenu.BackColor = Color.FromArgb(49, 194, 124);
            SearchMenu.ForeColor = Color.FromArgb(247, 247, 247);

            SaveResultMenu.BackColor = Color.FromArgb(237, 237, 237);
            SaveResultMenu.ForeColor = Color.FromArgb(99, 99, 99);


            DisplayPanel.Controls.Add(this._searchTab);
            DisplayPanel.Controls.Add(this._createIndexTab);
            DisplayPanel.Controls.Add(this._saveResultTab);
            this._searchTab.BringToFront();
            this._createIndexTab.Dock = DockStyle.Fill;
            this._searchTab.Dock = DockStyle.Fill;
            this._saveResultTab.Dock = DockStyle.Fill;

//            QueryBox.AutoCompleteMode = AutoCompleteMode.Suggest;
////            List<string> list = new List<string>();
//            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
//            collection.Add("super");
//            collection.Add("sorry");
//            collection.Add("summer");
//            QueryBox.AutoCompleteCustomSource = collection;
        }

        

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void IndexMenu_Click(object sender, MouseEventArgs e)
        {
            IndexMenu.BackColor = Color.FromArgb(49, 194, 124);
            IndexMenu.ForeColor = Color.FromArgb(237, 237, 237);

            SearchMenu.BackColor = Color.FromArgb(237, 237, 237);
            SearchMenu.ForeColor = Color.FromArgb(99, 99, 99);

            SaveResultMenu.BackColor = Color.FromArgb(237, 237, 237);
            SaveResultMenu.ForeColor = Color.FromArgb(99, 99, 99);


            //            if (!DisplayPanel.Controls.Contains(CreateIndexTab.Instance))
            //            {
            //                DisplayPanel.Controls.Add(CreateIndexTab.Instance);
            //                CreateIndexTab.Instance.Dock = DockStyle.Fill;
            //                CreateIndexTab.Instance.BringToFront();
            //            }
            //            else
            //            {
            //                CreateIndexTab.Instance.BringToFront();
            //            }

            _createIndexTab.BringToFront();
        }

        private void SearchMenu_Click_1(object sender, EventArgs e)
        {
            IndexMenu.BackColor = Color.FromArgb(237, 237, 237);
            IndexMenu.ForeColor = Color.FromArgb(99, 99, 99);

            SearchMenu.BackColor = Color.FromArgb(49, 194, 124);
            SearchMenu.ForeColor = Color.FromArgb(247, 247, 247);

            SaveResultMenu.BackColor = Color.FromArgb(237, 237, 237);
            SaveResultMenu.ForeColor = Color.FromArgb(99, 99, 99);


            if (_createIndexTab.indexChanged)
            {
                this._searchTab.IndexPath = _createIndexTab.IndexPath;
            }

            this._searchTab.BringToFront();
        }

        private void SaveResultMenu_Click(object sender, EventArgs e)
        {
            IndexMenu.BackColor = Color.FromArgb(237, 237, 237);
            IndexMenu.ForeColor = Color.FromArgb(99, 99, 99);

            SearchMenu.BackColor = Color.FromArgb(237, 237, 237);
            SearchMenu.ForeColor = Color.FromArgb(99, 99, 99);


            SaveResultMenu.BackColor = Color.FromArgb(49, 194, 124);
            SaveResultMenu.ForeColor = Color.FromArgb(247, 247, 247);

            this._saveResultTab.BringToFront();

            if (_searchTab.TopicIdChanged)
            {
                _saveResultTab.TopicIDBox.Text = _searchTab.TopicId;
                _searchTab.TopicIdChanged = false;
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            //GUI
            IndexMenu.BackColor = Color.FromArgb(237, 237, 237);
            IndexMenu.ForeColor = Color.FromArgb(99, 99, 99);

            SearchMenu.BackColor = Color.FromArgb(49, 194, 124);
            SearchMenu.ForeColor = Color.FromArgb(247, 247, 247);

            SaveResultMenu.BackColor = Color.FromArgb(237, 237, 237);
            SaveResultMenu.ForeColor = Color.FromArgb(99, 99, 99);


            if (_createIndexTab.indexChanged)
            {
                this._searchTab.IndexPath = _createIndexTab.IndexPath;
            }

            this._searchTab.BringToFront();
            TimeTakenToSearch.Text = "Search completed in " + _searchTab.LuceneSearch(QueryBox.Text) + " ms";
        }


        private void TimeTakenToSearch_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryBox.Text = _searchTab.QueryText;
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
        }
    }
}