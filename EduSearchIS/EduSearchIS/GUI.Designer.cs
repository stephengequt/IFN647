namespace EduSearchIS
{
    partial class GUI
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
            this.CollectionButton = new System.Windows.Forms.Button();
            this.IndexButton = new System.Windows.Forms.Button();
            this.CollectionLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.folderToReadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CollectionButton
            // 
            this.CollectionButton.Location = new System.Drawing.Point(21, 25);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(111, 23);
            this.CollectionButton.TabIndex = 0;
            this.CollectionButton.Text = "Browse";
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // IndexButton
            // 
            this.IndexButton.Location = new System.Drawing.Point(21, 87);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(111, 23);
            this.IndexButton.TabIndex = 1;
            this.IndexButton.Text = "Browse";
            this.IndexButton.UseVisualStyleBackColor = true;
            this.IndexButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CollectionLabel
            // 
            this.CollectionLabel.AutoSize = true;
            this.CollectionLabel.Location = new System.Drawing.Point(201, 28);
            this.CollectionLabel.Name = "CollectionLabel";
            this.CollectionLabel.Size = new System.Drawing.Size(130, 17);
            this.CollectionLabel.TabIndex = 2;
            this.CollectionLabel.Text = "Collection Directory";
            this.CollectionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(201, 87);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(102, 17);
            this.IndexLabel.TabIndex = 3;
            this.IndexLabel.Text = "Index Directory";
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Location = new System.Drawing.Point(319, 159);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(107, 23);
            this.CreateIndexButton.TabIndex = 4;
            this.CreateIndexButton.Text = "Create Index";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // folderToReadLocation
            // 
            this.folderToReadLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateIndexButton);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.CollectionLabel);
            this.Controls.Add(this.IndexButton);
            this.Controls.Add(this.CollectionButton);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.Label CollectionLabel;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.FolderBrowserDialog folderToReadLocation;
    }
}