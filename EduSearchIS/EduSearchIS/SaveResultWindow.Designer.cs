namespace EduSearchIS
{
    partial class SaveResultWindow
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
            this.ResultDirectoryText = new System.Windows.Forms.TextBox();
            this.BrowseResultButton = new System.Windows.Forms.Button();
            this.TopicIDBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultDirectoryText
            // 
            this.ResultDirectoryText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ResultDirectoryText.Location = new System.Drawing.Point(287, 38);
            this.ResultDirectoryText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ResultDirectoryText.Name = "ResultDirectoryText";
            this.ResultDirectoryText.Size = new System.Drawing.Size(307, 35);
            this.ResultDirectoryText.TabIndex = 23;
            this.ResultDirectoryText.Text = "Insert Result Directory";
            // 
            // BrowseResultButton
            // 
            this.BrowseResultButton.Location = new System.Drawing.Point(615, 34);
            this.BrowseResultButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BrowseResultButton.Name = "BrowseResultButton";
            this.BrowseResultButton.Size = new System.Drawing.Size(131, 42);
            this.BrowseResultButton.TabIndex = 24;
            this.BrowseResultButton.Text = "Browse";
            this.BrowseResultButton.UseVisualStyleBackColor = true;
            this.BrowseResultButton.Click += new System.EventHandler(this.BrowseResultButton_Click);
            // 
            // TopicIDBox
            // 
            this.TopicIDBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TopicIDBox.Location = new System.Drawing.Point(287, 113);
            this.TopicIDBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TopicIDBox.Name = "TopicIDBox";
            this.TopicIDBox.Size = new System.Drawing.Size(307, 35);
            this.TopicIDBox.TabIndex = 26;
            this.TopicIDBox.Text = "Enter Topic ID";
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(273, 222);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(201, 42);
            this.ResultButton.TabIndex = 25;
            this.ResultButton.Text = "Save Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Topic ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Directory to save result:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopicIDBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.BrowseResultButton);
            this.Controls.Add(this.ResultDirectoryText);
            this.Name = "SaveResultWindow";
            this.Text = "SaveResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultDirectoryText;
        private System.Windows.Forms.Button BrowseResultButton;
        private System.Windows.Forms.TextBox TopicIDBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}