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
            this.components = new System.ComponentModel.Container();
            this.folderToReadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.QueryFileBrowseButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.SpellCheckOptCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TimeTakenToSearch = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.SaveResultMenu = new System.Windows.Forms.Button();
            this.SearchMenu = new System.Windows.Forms.Button();
            this.IndexMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.White;
            this.DisplayPanel.ForeColor = System.Drawing.Color.Black;
            this.DisplayPanel.Location = new System.Drawing.Point(216, 108);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(2234, 1271);
            this.DisplayPanel.TabIndex = 44;
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
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SpellCheckOptCheckBox);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.StatusLabel);
            this.panel3.Controls.Add(this.TimeTakenToSearch);
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Controls.Add(this.QueryBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1382);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2450, 238);
            this.panel3.TabIndex = 46;
            // 
            // SpellCheckOptCheckBox
            // 
            this.SpellCheckOptCheckBox.AutoSize = true;
            this.SpellCheckOptCheckBox.Location = new System.Drawing.Point(491, 135);
            this.SpellCheckOptCheckBox.Name = "SpellCheckOptCheckBox";
            this.SpellCheckOptCheckBox.Size = new System.Drawing.Size(175, 33);
            this.SpellCheckOptCheckBox.TabIndex = 42;
            this.SpellCheckOptCheckBox.Text = "Spell Check";
            this.SpellCheckOptCheckBox.UseVisualStyleBackColor = true;
            this.SpellCheckOptCheckBox.CheckedChanged += new System.EventHandler(this.SpellCheckOptCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 61);
            this.button1.TabIndex = 41;
            this.button1.Text = "Quick Copy From Selected Query";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(486, 22);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(167, 29);
            this.StatusLabel.TabIndex = 40;
            this.StatusLabel.Text = "Search Status:";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // TimeTakenToSearch
            // 
            this.TimeTakenToSearch.AutoSize = true;
            this.TimeTakenToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenToSearch.Location = new System.Drawing.Point(1073, 22);
            this.TimeTakenToSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeTakenToSearch.Name = "TimeTakenToSearch";
            this.TimeTakenToSearch.Size = new System.Drawing.Size(257, 29);
            this.TimeTakenToSearch.TabIndex = 39;
            this.TimeTakenToSearch.Text = "Time Taken to Search:";
            this.TimeTakenToSearch.Click += new System.EventHandler(this.TimeTakenToSearch_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(2044, 74);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(380, 72);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // QueryBox
            // 
            this.QueryBox.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "what \"similarity laws\" must be obeyed when constructing aeroelastic models",
            "of heated high speed aircraft",
            "",
            "what are the structural and aeroelastic problems associated with flight",
            "of high speed aircraft",
            "",
            "how can the aerodynamic performance of channel flow ground effect",
            "machines be calculated",
            "",
            "in summarizing theoretical and experimental work on the behaviour of a",
            "typical aircraft structure in a noise environment is it possible to",
            "develop a design procedure ",
            "",
            "has anyone developed an analysis which accurately establishes the large",
            "deflection behaviour of \"conical shells\""});
            this.QueryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.QueryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.QueryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBox.ForeColor = System.Drawing.Color.Gray;
            this.QueryBox.Location = new System.Drawing.Point(491, 74);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(4);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(1532, 41);
            this.QueryBox.TabIndex = 9;
            this.QueryBox.Text = "Enter Query Here...";
            this.QueryBox.Enter += new System.EventHandler(this.QueryBox_Enter);
            this.QueryBox.Leave += new System.EventHandler(this.QueryBox_Leave);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.sidepanel.Controls.Add(this.SaveResultMenu);
            this.sidepanel.Controls.Add(this.SearchMenu);
            this.sidepanel.Controls.Add(this.IndexMenu);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(216, 1382);
            this.sidepanel.TabIndex = 47;
            // 
            // SaveResultMenu
            // 
            this.SaveResultMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.SaveResultMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveResultMenu.FlatAppearance.BorderSize = 0;
            this.SaveResultMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(156)))));
            this.SaveResultMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveResultMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveResultMenu.ForeColor = System.Drawing.Color.Black;
            this.SaveResultMenu.Location = new System.Drawing.Point(0, 320);
            this.SaveResultMenu.Margin = new System.Windows.Forms.Padding(2);
            this.SaveResultMenu.Name = "SaveResultMenu";
            this.SaveResultMenu.Size = new System.Drawing.Size(216, 108);
            this.SaveResultMenu.TabIndex = 4;
            this.SaveResultMenu.Text = "Save Result";
            this.SaveResultMenu.UseVisualStyleBackColor = false;
            this.SaveResultMenu.Click += new System.EventHandler(this.SaveResultMenu_Click);
            // 
            // SearchMenu
            // 
            this.SearchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.SearchMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchMenu.FlatAppearance.BorderSize = 0;
            this.SearchMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(156)))));
            this.SearchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMenu.ForeColor = System.Drawing.Color.Black;
            this.SearchMenu.Location = new System.Drawing.Point(0, 212);
            this.SearchMenu.Margin = new System.Windows.Forms.Padding(2);
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(216, 108);
            this.SearchMenu.TabIndex = 2;
            this.SearchMenu.Text = "Search";
            this.SearchMenu.UseVisualStyleBackColor = false;
            this.SearchMenu.Click += new System.EventHandler(this.SearchMenu_Click_1);
            // 
            // IndexMenu
            // 
            this.IndexMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.IndexMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.IndexMenu.FlatAppearance.BorderSize = 0;
            this.IndexMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(156)))));
            this.IndexMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IndexMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexMenu.ForeColor = System.Drawing.Color.Black;
            this.IndexMenu.Location = new System.Drawing.Point(0, 104);
            this.IndexMenu.Margin = new System.Windows.Forms.Padding(2);
            this.IndexMenu.Name = "IndexMenu";
            this.IndexMenu.Size = new System.Drawing.Size(216, 108);
            this.IndexMenu.TabIndex = 1;
            this.IndexMenu.Text = "Create Index";
            this.IndexMenu.UseVisualStyleBackColor = false;
            this.IndexMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IndexMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 104);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "EduSearch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2234, 108);
            this.panel2.TabIndex = 48;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(194)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(587, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kingsland University of Technology";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(2180, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(54, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 41);
            this.toolStripMenuItem1.Text = "X";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Correction:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1382, 35);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2450, 1620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sidepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderToReadLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button QueryFileBrowseButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button SaveResultMenu;
        private System.Windows.Forms.Button SearchMenu;
        private System.Windows.Forms.Button IndexMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TimeTakenToSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SpellCheckOptCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}