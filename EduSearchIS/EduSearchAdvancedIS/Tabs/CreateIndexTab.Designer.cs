namespace EduSearchAdvancedIS
{
    partial class CreateIndexTab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CollectionDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.IndexDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.CollectionButton = new System.Windows.Forms.Button();
            this.IndexButton = new System.Windows.Forms.Button();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.TimeLabelToIndex = new System.Windows.Forms.Label();
            this.folderToReadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(56, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1183, 602);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // CollectionDirectoryTextBox
            // 
            this.CollectionDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDirectoryTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CollectionDirectoryTextBox.Location = new System.Drawing.Point(28, 71);
            this.CollectionDirectoryTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CollectionDirectoryTextBox.Name = "CollectionDirectoryTextBox";
            this.CollectionDirectoryTextBox.Size = new System.Drawing.Size(800, 34);
            this.CollectionDirectoryTextBox.TabIndex = 5;
            this.CollectionDirectoryTextBox.Text = "Insert Collection Directory";
            this.CollectionDirectoryTextBox.TextChanged += new System.EventHandler(this.CollectionDirectoryTextBox_TextChanged);
            // 
            // IndexDirectoryTextBox
            // 
            this.IndexDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexDirectoryTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IndexDirectoryTextBox.Location = new System.Drawing.Point(28, 156);
            this.IndexDirectoryTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IndexDirectoryTextBox.Name = "IndexDirectoryTextBox";
            this.IndexDirectoryTextBox.Size = new System.Drawing.Size(800, 34);
            this.IndexDirectoryTextBox.TabIndex = 6;
            this.IndexDirectoryTextBox.Text = "Insert Index Directory";
            // 
            // CollectionButton
            // 
            this.CollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionButton.Location = new System.Drawing.Point(863, 71);
            this.CollectionButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(240, 42);
            this.CollectionButton.TabIndex = 0;
            this.CollectionButton.Text = "Browse";
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // IndexButton
            // 
            this.IndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexButton.Location = new System.Drawing.Point(863, 156);
            this.IndexButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(240, 42);
            this.IndexButton.TabIndex = 1;
            this.IndexButton.Text = "Browse";
            this.IndexButton.UseVisualStyleBackColor = true;
            this.IndexButton.Click += new System.EventHandler(this.IndexButton_Click);
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateIndexButton.Location = new System.Drawing.Point(350, 404);
            this.CreateIndexButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(380, 85);
            this.CreateIndexButton.TabIndex = 4;
            this.CreateIndexButton.Text = "Create Index";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // TimeLabelToIndex
            // 
            this.TimeLabelToIndex.AutoSize = true;
            this.TimeLabelToIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabelToIndex.Location = new System.Drawing.Point(243, 250);
            this.TimeLabelToIndex.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLabelToIndex.Name = "TimeLabelToIndex";
            this.TimeLabelToIndex.Size = new System.Drawing.Size(239, 29);
            this.TimeLabelToIndex.TabIndex = 7;
            this.TimeLabelToIndex.Text = "Time Taken to Index:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2317, 100);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Index";
            // 
            // CreateIndexTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateIndexTab";
            this.Size = new System.Drawing.Size(2317, 1450);
            this.Load += new System.EventHandler(this.CreateIndexTab_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.FolderBrowserDialog folderToReadLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CollectionDirectoryTextBox;
        private System.Windows.Forms.TextBox IndexDirectoryTextBox;
        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.Label TimeLabelToIndex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
