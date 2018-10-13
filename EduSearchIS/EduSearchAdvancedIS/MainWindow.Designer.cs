namespace EduSearchAdvancedIS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.CollectionButton = new System.Windows.Forms.Button();
            this.IndexButton = new System.Windows.Forms.Button();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.folderToReadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.CollectionDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.IndexDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabelToIndex = new System.Windows.Forms.Label();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PreprocessingCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeTakenToSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.TotalPageLabel = new System.Windows.Forms.Label();
            this.AbstractButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.TopicIDBox = new System.Windows.Forms.TextBox();
            this.ResultDirectoryText = new System.Windows.Forms.TextBox();
            this.BrowseResultButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumOfResultText = new System.Windows.Forms.Label();
            this.ResultMsg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.QueryListView = new System.Windows.Forms.ListView();
            this.QueryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryFileDirectory = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SelectField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QueryExpansionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.QueryFileBrowseButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.FinalQueryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CollectionButton
            // 
            this.CollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionButton.Location = new System.Drawing.Point(493, 39);
            this.CollectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(137, 23);
            this.CollectionButton.TabIndex = 0;
            this.CollectionButton.Text = "Browse";
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // IndexButton
            // 
            this.IndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexButton.Location = new System.Drawing.Point(493, 86);
            this.IndexButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(137, 23);
            this.IndexButton.TabIndex = 1;
            this.IndexButton.Text = "Browse";
            this.IndexButton.UseVisualStyleBackColor = true;
            this.IndexButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateIndexButton.Location = new System.Drawing.Point(705, 39);
            this.CreateIndexButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(217, 47);
            this.CreateIndexButton.TabIndex = 4;
            this.CreateIndexButton.Text = "Create Index";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // folderToReadLocation
            // 
            this.folderToReadLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // CollectionDirectoryTextBox
            // 
            this.CollectionDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDirectoryTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CollectionDirectoryTextBox.Location = new System.Drawing.Point(16, 39);
            this.CollectionDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CollectionDirectoryTextBox.Name = "CollectionDirectoryTextBox";
            this.CollectionDirectoryTextBox.Size = new System.Drawing.Size(459, 22);
            this.CollectionDirectoryTextBox.TabIndex = 5;
            this.CollectionDirectoryTextBox.Text = "Insert Collection Directory";
            this.CollectionDirectoryTextBox.TextChanged += new System.EventHandler(this.CollectionDirectoryTextBox_TextChanged);
            this.CollectionDirectoryTextBox.Enter += new System.EventHandler(this.CollectionDirectoryTextBox_Enter);
            this.CollectionDirectoryTextBox.Leave += new System.EventHandler(this.CollectionDirectoryTextBox_Leave);
            // 
            // IndexDirectoryTextBox
            // 
            this.IndexDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexDirectoryTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IndexDirectoryTextBox.Location = new System.Drawing.Point(16, 86);
            this.IndexDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IndexDirectoryTextBox.Name = "IndexDirectoryTextBox";
            this.IndexDirectoryTextBox.Size = new System.Drawing.Size(459, 22);
            this.IndexDirectoryTextBox.TabIndex = 6;
            this.IndexDirectoryTextBox.Text = "Insert Index Directory";
            this.IndexDirectoryTextBox.TextChanged += new System.EventHandler(this.IndexDirectoryTextBox_TextChanged);
            this.IndexDirectoryTextBox.Enter += new System.EventHandler(this.IndexDirectoryTextBox_Enter);
            this.IndexDirectoryTextBox.Leave += new System.EventHandler(this.IndexDirectoryTextBox_Leave);
            // 
            // TimeLabelToIndex
            // 
            this.TimeLabelToIndex.AutoSize = true;
            this.TimeLabelToIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabelToIndex.Location = new System.Drawing.Point(779, 105);
            this.TimeLabelToIndex.Name = "TimeLabelToIndex";
            this.TimeLabelToIndex.Size = new System.Drawing.Size(140, 17);
            this.TimeLabelToIndex.TabIndex = 7;
            this.TimeLabelToIndex.Text = "Time Taken to Index:";
            this.TimeLabelToIndex.Click += new System.EventHandler(this.TimeLabelToIndex_Click);
            // 
            // QueryBox
            // 
            this.QueryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QueryBox.Location = new System.Drawing.Point(16, 28);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(657, 26);
            this.QueryBox.TabIndex = 8;
            this.QueryBox.Text = "Enter Query";
            this.QueryBox.TextChanged += new System.EventHandler(this.QueryBox_TextChanged);
            this.QueryBox.Enter += new System.EventHandler(this.QueryBox_Enter);
            this.QueryBox.Leave += new System.EventHandler(this.QueryBox_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(705, 28);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(217, 30);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PreprocessingCheckBox
            // 
            this.PreprocessingCheckBox.AutoSize = true;
            this.PreprocessingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreprocessingCheckBox.Location = new System.Drawing.Point(16, 78);
            this.PreprocessingCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreprocessingCheckBox.Name = "PreprocessingCheckBox";
            this.PreprocessingCheckBox.Size = new System.Drawing.Size(208, 21);
            this.PreprocessingCheckBox.TabIndex = 10;
            this.PreprocessingCheckBox.Text = "Pre-Processing not required";
            this.PreprocessingCheckBox.UseVisualStyleBackColor = true;
            this.PreprocessingCheckBox.CheckedChanged += new System.EventHandler(this.PreprocessingCheckBox_CheckedChanged);
            // 
            // TimeTakenToSearch
            // 
            this.TimeTakenToSearch.AutoSize = true;
            this.TimeTakenToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenToSearch.Location = new System.Drawing.Point(347, 43);
            this.TimeTakenToSearch.Name = "TimeTakenToSearch";
            this.TimeTakenToSearch.Size = new System.Drawing.Size(152, 17);
            this.TimeTakenToSearch.TabIndex = 11;
            this.TimeTakenToSearch.Text = "Time Taken to Search:";
            this.TimeTakenToSearch.Click += new System.EventHandler(this.TimeTakenToSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(11, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 415);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.Location = new System.Drawing.Point(391, 562);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 14;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(655, 561);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Page";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PageNumLabel
            // 
            this.PageNumLabel.AutoSize = true;
            this.PageNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNumLabel.Location = new System.Drawing.Point(541, 564);
            this.PageNumLabel.Name = "PageNumLabel";
            this.PageNumLabel.Size = new System.Drawing.Size(16, 17);
            this.PageNumLabel.TabIndex = 17;
            this.PageNumLabel.Text = "1";
            this.PageNumLabel.Click += new System.EventHandler(this.PageNumLabel_Click);
            // 
            // TotalPageLabel
            // 
            this.TotalPageLabel.AutoSize = true;
            this.TotalPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPageLabel.Location = new System.Drawing.Point(564, 564);
            this.TotalPageLabel.Name = "TotalPageLabel";
            this.TotalPageLabel.Size = new System.Drawing.Size(56, 17);
            this.TotalPageLabel.TabIndex = 18;
            this.TotalPageLabel.Text = "out of 1";
            this.TotalPageLabel.Click += new System.EventHandler(this.TotalPageLabel_Click);
            // 
            // AbstractButton
            // 
            this.AbstractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbstractButton.Location = new System.Drawing.Point(960, 558);
            this.AbstractButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbstractButton.Name = "AbstractButton";
            this.AbstractButton.Size = new System.Drawing.Size(115, 23);
            this.AbstractButton.TabIndex = 19;
            this.AbstractButton.Text = "View Abstract";
            this.AbstractButton.UseVisualStyleBackColor = true;
            this.AbstractButton.Click += new System.EventHandler(this.AbstractButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(421, 112);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(115, 23);
            this.ResultButton.TabIndex = 20;
            this.ResultButton.Text = "Save Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // TopicIDBox
            // 
            this.TopicIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicIDBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopicIDBox.Location = new System.Drawing.Point(11, 112);
            this.TopicIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopicIDBox.Name = "TopicIDBox";
            this.TopicIDBox.Size = new System.Drawing.Size(393, 22);
            this.TopicIDBox.TabIndex = 21;
            this.TopicIDBox.Text = "Enter Topic ID";
            this.TopicIDBox.TextChanged += new System.EventHandler(this.TopicIDBox_TextChanged);
            this.TopicIDBox.Enter += new System.EventHandler(this.TopicIDBox_Enter);
            this.TopicIDBox.Leave += new System.EventHandler(this.TopicIDBox_Leave);
            // 
            // ResultDirectoryText
            // 
            this.ResultDirectoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultDirectoryText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResultDirectoryText.Location = new System.Drawing.Point(11, 71);
            this.ResultDirectoryText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultDirectoryText.Name = "ResultDirectoryText";
            this.ResultDirectoryText.Size = new System.Drawing.Size(393, 22);
            this.ResultDirectoryText.TabIndex = 22;
            this.ResultDirectoryText.Text = "Insert Result Directory";
            this.ResultDirectoryText.TextChanged += new System.EventHandler(this.ResultDirectoryText_TextChanged);
            this.ResultDirectoryText.Enter += new System.EventHandler(this.ResultDirectoryText_Enter);
            this.ResultDirectoryText.Leave += new System.EventHandler(this.ResultDirectoryText_Leave);
            // 
            // BrowseResultButton
            // 
            this.BrowseResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseResultButton.Location = new System.Drawing.Point(421, 70);
            this.BrowseResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseResultButton.Name = "BrowseResultButton";
            this.BrowseResultButton.Size = new System.Drawing.Size(115, 23);
            this.BrowseResultButton.TabIndex = 23;
            this.BrowseResultButton.Text = "Browse";
            this.BrowseResultButton.UseVisualStyleBackColor = true;
            this.BrowseResultButton.Click += new System.EventHandler(this.BrowseResultButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Final Query:";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Number of Result:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NumOfResultText
            // 
            this.NumOfResultText.AutoSize = true;
            this.NumOfResultText.BackColor = System.Drawing.SystemColors.Control;
            this.NumOfResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfResultText.Location = new System.Drawing.Point(134, 96);
            this.NumOfResultText.Name = "NumOfResultText";
            this.NumOfResultText.Size = new System.Drawing.Size(0, 17);
            this.NumOfResultText.TabIndex = 27;
            // 
            // ResultMsg
            // 
            this.ResultMsg.AutoSize = true;
            this.ResultMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultMsg.Location = new System.Drawing.Point(419, 188);
            this.ResultMsg.Name = "ResultMsg";
            this.ResultMsg.Size = new System.Drawing.Size(90, 17);
            this.ResultMsg.TabIndex = 28;
            this.ResultMsg.Text = "Result status";
            this.ResultMsg.Click += new System.EventHandler(this.ResultMsg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.newWindowToolStripMenuItem.Text = "new window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveResultToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.menuToolStripMenuItem.Text = "Option";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.saveResultToolStripMenuItem.Text = "Save Result";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Insert Query File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QueryListView
            // 
            this.QueryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QueryID,
            this.QueryContent});
            this.QueryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryListView.FullRowSelect = true;
            this.QueryListView.GridLines = true;
            this.QueryListView.Location = new System.Drawing.Point(27, 126);
            this.QueryListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryListView.Name = "QueryListView";
            this.QueryListView.Size = new System.Drawing.Size(519, 219);
            this.QueryListView.TabIndex = 32;
            this.QueryListView.UseCompatibleStateImageBehavior = false;
            this.QueryListView.UseWaitCursor = true;
            this.QueryListView.View = System.Windows.Forms.View.Details;
            this.QueryListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.QueryListView_ItemSelectionChanged);
            this.QueryListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // QueryID
            // 
            this.QueryID.Text = "Query ID";
            // 
            // QueryContent
            // 
            this.QueryContent.Text = "Query Content";
            this.QueryContent.Width = 400;
            // 
            // QueryFileDirectory
            // 
            this.QueryFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryFileDirectory.Location = new System.Drawing.Point(27, 44);
            this.QueryFileDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryFileDirectory.Multiline = true;
            this.QueryFileDirectory.Name = "QueryFileDirectory";
            this.QueryFileDirectory.Size = new System.Drawing.Size(335, 24);
            this.QueryFileDirectory.TabIndex = 33;
            this.QueryFileDirectory.Text = "Insert Query File Location";
            this.QueryFileDirectory.TextChanged += new System.EventHandler(this.QueryFileDirectory_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(8, 43);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(97, 17);
            this.StatusLabel.TabIndex = 34;
            this.StatusLabel.Text = "Search Status";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // SelectField
            // 
            this.SelectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectField.FormattingEnabled = true;
            this.SelectField.Items.AddRange(new object[] {
            "Full text",
            "Author",
            "Title"});
            this.SelectField.Location = new System.Drawing.Point(808, 75);
            this.SelectField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectField.Name = "SelectField";
            this.SelectField.Size = new System.Drawing.Size(113, 24);
            this.SelectField.TabIndex = 35;
            this.SelectField.SelectedIndexChanged += new System.EventHandler(this.SelectField_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(677, 46);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kingsland University of Technology";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.CollectionDirectoryTextBox);
            this.groupBox1.Controls.Add(this.IndexDirectoryTextBox);
            this.groupBox1.Controls.Add(this.CollectionButton);
            this.groupBox1.Controls.Add(this.IndexButton);
            this.groupBox1.Controls.Add(this.CreateIndexButton);
            this.groupBox1.Controls.Add(this.TimeLabelToIndex);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(544, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(956, 147);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Index";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QueryExpansionCheckBox);
            this.groupBox2.Controls.Add(this.PreprocessingCheckBox);
            this.groupBox2.Controls.Add(this.QueryBox);
            this.groupBox2.Controls.Add(this.SelectField);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(544, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(956, 127);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // QueryExpansionCheckBox
            // 
            this.QueryExpansionCheckBox.AutoSize = true;
            this.QueryExpansionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryExpansionCheckBox.Location = new System.Drawing.Point(203, 63);
            this.QueryExpansionCheckBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.QueryExpansionCheckBox.Name = "QueryExpansionCheckBox";
            this.QueryExpansionCheckBox.Size = new System.Drawing.Size(166, 17);
            this.QueryExpansionCheckBox.TabIndex = 36;
            this.QueryExpansionCheckBox.Text = "Query Expansion by NetWord";
            this.QueryExpansionCheckBox.UseVisualStyleBackColor = true;
            this.QueryExpansionCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StatusLabel);
            this.groupBox3.Controls.Add(this.NumOfResultText);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.TimeTakenToSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.PreviousButton);
            this.groupBox3.Controls.Add(this.AbstractButton);
            this.groupBox3.Controls.Add(this.NextButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.PageNumLabel);
            this.groupBox3.Controls.Add(this.TotalPageLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(144, 391);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1099, 597);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.QueryListView);
            this.groupBox4.Controls.Add(this.QueryFileDirectory);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1249, 391);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(563, 369);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query File";
            // 
            // QueryFileBrowseButton
            // 
            this.QueryFileBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryFileBrowseButton.Location = new System.Drawing.Point(288, 35);
            this.QueryFileBrowseButton.Name = "QueryFileBrowseButton";
            this.QueryFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.QueryFileBrowseButton.TabIndex = 34;
            this.QueryFileBrowseButton.Text = "Browse";
            this.QueryFileBrowseButton.UseVisualStyleBackColor = true;
            this.QueryFileBrowseButton.Click += new System.EventHandler(this.QueryFileBrowseButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ResultDirectoryText);
            this.groupBox5.Controls.Add(this.TopicIDBox);
            this.groupBox5.Controls.Add(this.ResultMsg);
            this.groupBox5.Controls.Add(this.ResultButton);
            this.groupBox5.Controls.Add(this.BrowseResultButton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1249, 766);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(563, 222);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save Result";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FinalQueryTextBox
            // 
            this.FinalQueryTextBox.Location = new System.Drawing.Point(31, 120);
            this.FinalQueryTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FinalQueryTextBox.Multiline = true;
            this.FinalQueryTextBox.Name = "FinalQueryTextBox";
            this.FinalQueryTextBox.Size = new System.Drawing.Size(346, 177);
            this.FinalQueryTextBox.TabIndex = 42;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 805);
            this.Controls.Add(this.FinalQueryTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.FolderBrowserDialog folderToReadLocation;
        private System.Windows.Forms.TextBox CollectionDirectoryTextBox;
        private System.Windows.Forms.TextBox IndexDirectoryTextBox;
        private System.Windows.Forms.Label TimeLabelToIndex;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox PreprocessingCheckBox;
        private System.Windows.Forms.Label TimeTakenToSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PageNumLabel;
        private System.Windows.Forms.Label TotalPageLabel;
        private System.Windows.Forms.Button AbstractButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox TopicIDBox;
        private System.Windows.Forms.TextBox ResultDirectoryText;
        private System.Windows.Forms.Button BrowseResultButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumOfResultText;
        private System.Windows.Forms.Label ResultMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView QueryListView;
        private System.Windows.Forms.TextBox QueryFileDirectory;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ColumnHeader QueryID;
        private System.Windows.Forms.ColumnHeader QueryContent;
        private System.Windows.Forms.ComboBox SelectField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button QueryFileBrowseButton;
        private System.Windows.Forms.CheckBox QueryExpansionCheckBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox FinalQueryTextBox;
    }
}