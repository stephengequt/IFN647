namespace EduSearchAdvancedIS.Tabs
{
    partial class SearchTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryExpansionCheckBox = new System.Windows.Forms.CheckBox();
            this.PreprocessingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumOfResultText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.AbstractButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.TotalPageLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.QueryListView = new System.Windows.Forms.ListView();
            this.QueryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryFileDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bibliography = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbstractPreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryExpansionCheckBox
            // 
            this.QueryExpansionCheckBox.AutoSize = true;
            this.QueryExpansionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryExpansionCheckBox.Location = new System.Drawing.Point(22, 144);
            this.QueryExpansionCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryExpansionCheckBox.Name = "QueryExpansionCheckBox";
            this.QueryExpansionCheckBox.Size = new System.Drawing.Size(361, 33);
            this.QueryExpansionCheckBox.TabIndex = 36;
            this.QueryExpansionCheckBox.Text = "Query Expansion by NetWord";
            this.QueryExpansionCheckBox.UseVisualStyleBackColor = true;
            this.QueryExpansionCheckBox.CheckedChanged += new System.EventHandler(this.QueryExpansionCheckBox_CheckedChanged);
            // 
            // PreprocessingCheckBox
            // 
            this.PreprocessingCheckBox.AutoSize = true;
            this.PreprocessingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreprocessingCheckBox.Location = new System.Drawing.Point(22, 94);
            this.PreprocessingCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PreprocessingCheckBox.Name = "PreprocessingCheckBox";
            this.PreprocessingCheckBox.Size = new System.Drawing.Size(348, 33);
            this.PreprocessingCheckBox.TabIndex = 10;
            this.PreprocessingCheckBox.Text = "Pre-Processing not required";
            this.PreprocessingCheckBox.UseVisualStyleBackColor = true;
            this.PreprocessingCheckBox.CheckedChanged += new System.EventHandler(this.PreprocessingCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NumOfResultText);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 593);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(2044, 1494);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // NumOfResultText
            // 
            this.NumOfResultText.AutoSize = true;
            this.NumOfResultText.BackColor = System.Drawing.SystemColors.Control;
            this.NumOfResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfResultText.Location = new System.Drawing.Point(1763, 66);
            this.NumOfResultText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumOfResultText.Name = "NumOfResultText";
            this.NumOfResultText.Size = new System.Drawing.Size(0, 29);
            this.NumOfResultText.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Title,
            this.Author,
            this.Bibliography,
            this.AbstractPreview});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2003, 1259);
            this.dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1547, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Number of Result:";
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(663, 535);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(98, 52);
            this.PreviousButton.TabIndex = 14;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // AbstractButton
            // 
            this.AbstractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.AbstractButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbstractButton.ForeColor = System.Drawing.Color.White;
            this.AbstractButton.Location = new System.Drawing.Point(1519, 513);
            this.AbstractButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AbstractButton.Name = "AbstractButton";
            this.AbstractButton.Size = new System.Drawing.Size(288, 72);
            this.AbstractButton.TabIndex = 19;
            this.AbstractButton.Text = "View Abstract";
            this.AbstractButton.UseVisualStyleBackColor = false;
            this.AbstractButton.Click += new System.EventHandler(this.AbstractButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(1098, 533);
            this.NextButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(98, 52);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(819, 546);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Page";
            // 
            // PageNumLabel
            // 
            this.PageNumLabel.AutoSize = true;
            this.PageNumLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.PageNumLabel.Location = new System.Drawing.Point(901, 546);
            this.PageNumLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PageNumLabel.Name = "PageNumLabel";
            this.PageNumLabel.Size = new System.Drawing.Size(29, 31);
            this.PageNumLabel.TabIndex = 17;
            this.PageNumLabel.Text = "1";
            // 
            // TotalPageLabel
            // 
            this.TotalPageLabel.AutoSize = true;
            this.TotalPageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.TotalPageLabel.Location = new System.Drawing.Point(940, 546);
            this.TotalPageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TotalPageLabel.Name = "TotalPageLabel";
            this.TotalPageLabel.Size = new System.Drawing.Size(111, 31);
            this.TotalPageLabel.TabIndex = 18;
            this.TotalPageLabel.Text = "out of 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.QueryListView);
            this.groupBox4.Controls.Add(this.QueryFileDirectory);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(44, 119);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(1156, 372);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // QueryListView
            // 
            this.QueryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QueryID,
            this.QueryContent});
            this.QueryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryListView.FullRowSelect = true;
            this.QueryListView.GridLines = true;
            this.QueryListView.Location = new System.Drawing.Point(18, 161);
            this.QueryListView.Margin = new System.Windows.Forms.Padding(7);
            this.QueryListView.Name = "QueryListView";
            this.QueryListView.Size = new System.Drawing.Size(1134, 184);
            this.QueryListView.TabIndex = 32;
            this.QueryListView.UseCompatibleStateImageBehavior = false;
            this.QueryListView.UseWaitCursor = true;
            this.QueryListView.View = System.Windows.Forms.View.Details;
            this.QueryListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.SelectField_SelectedIndexChanged);
            this.QueryListView.SelectedIndexChanged += new System.EventHandler(this.QueryListView_SelectedIndexChanged);
            // 
            // QueryID
            // 
            this.QueryID.Text = "Query ID";
            this.QueryID.Width = 120;
            // 
            // QueryContent
            // 
            this.QueryContent.Text = "Query Content";
            this.QueryContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QueryContent.Width = 1000;
            // 
            // QueryFileDirectory
            // 
            this.QueryFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryFileDirectory.Location = new System.Drawing.Point(18, 104);
            this.QueryFileDirectory.Margin = new System.Windows.Forms.Padding(7);
            this.QueryFileDirectory.Multiline = true;
            this.QueryFileDirectory.Name = "QueryFileDirectory";
            this.QueryFileDirectory.Size = new System.Drawing.Size(583, 40);
            this.QueryFileDirectory.TabIndex = 33;
            this.QueryFileDirectory.Text = "Insert Query File Location";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(860, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Insert Query File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2234, 100);
            this.panel1.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 72);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 56);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quick Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 56);
            this.label6.TabIndex = 35;
            this.label6.Text = "Result";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(646, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 40);
            this.button3.TabIndex = 35;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(44, 517);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 51);
            this.button2.TabIndex = 48;
            this.button2.Text = "Display Final Query";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.QueryExpansionCheckBox);
            this.panel2.Controls.Add(this.PreprocessingCheckBox);
            this.panel2.Location = new System.Drawing.Point(1274, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 355);
            this.panel2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 56);
            this.label2.TabIndex = 36;
            this.label2.Text = "Advanced Search";
            // 
            // Rank
            // 
            this.Rank.FillWeight = 20F;
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.FillWeight = 90F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.FillWeight = 30F;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Bibliography
            // 
            this.Bibliography.FillWeight = 40F;
            this.Bibliography.HeaderText = "Bibliography";
            this.Bibliography.Name = "Bibliography";
            this.Bibliography.ReadOnly = true;
            // 
            // AbstractPreview
            // 
            this.AbstractPreview.FillWeight = 150F;
            this.AbstractPreview.HeaderText = "Abstract Preview";
            this.AbstractPreview.Name = "AbstractPreview";
            this.AbstractPreview.ReadOnly = true;
            // 
            // SearchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbstractButton);
            this.Controls.Add(this.PageNumLabel);
            this.Controls.Add(this.TotalPageLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchTab";
            this.Size = new System.Drawing.Size(2234, 2137);
            this.Load += new System.EventHandler(this.SearchTab_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox QueryExpansionCheckBox;
        private System.Windows.Forms.CheckBox PreprocessingCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label NumOfResultText;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button AbstractButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PageNumLabel;
        public System.Windows.Forms.Label TotalPageLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView QueryListView;
        private System.Windows.Forms.ColumnHeader QueryID;
        private System.Windows.Forms.ColumnHeader QueryContent;
        private System.Windows.Forms.TextBox QueryFileDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bibliography;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbstractPreview;
    }
}
