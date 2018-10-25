using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSearchAdvancedIS.Tabs
{
    public partial class SaveResultTab : UserControl
    {
        public DocInfo[] DocList { get; set; }

//        private static SaveResultTab _instance;
//
//        public static SaveResultTab Instance => _instance ?? (_instance = new SaveResultTab());
        public SaveResultTab(string topicId, DocInfo[] docList)
        {
            InitializeComponent();
            if (topicId != null)
            {
                TopicIDBox.Text = topicId;
            }

            if (docList != null)
            {
                this.DocList = docList;
            }
        }

        private void SaveResultTab_Load(object sender, EventArgs e)
        {
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (TopicIDBox.Text == "Enter Topic ID")
            {
                ResultMsg.ForeColor = Color.Red;
                ResultMsg.Text = "Topic ID is empty";
                //return;
            }

            else if (ResultDirectoryText.Text == "Insert Result Directory")
            {
                ResultMsg.ForeColor = Color.Red;
                ResultMsg.Text = "No file has been selected";
                //return;
            }

            else
            {
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                    {
                        foreach (DocInfo docInfo in this.DocList)
                        {
                            sw.Write(TopicIDBox.Text);
                            sw.Write(" Q0 ");
                            sw.Write(docInfo.DocID);
                            sw.Write(" " + docInfo.Rank);
                            sw.Write(" " + docInfo.DocScore);
                            sw.WriteLine(" 9370064_8021911_9617051_pancake");
                        }

                        ResultMsg.ForeColor = Color.Green;
                        ResultMsg.Text = "File has been created successfully";
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(saveFileDialog1.FileName))
                    {
                        foreach (DocInfo docInfo in this.DocList)
                        {
                            sw.Write(TopicIDBox.Text);
                            sw.Write(" Q0 ");
                            sw.Write(docInfo.DocID);
                            sw.Write(" " + docInfo.Rank);
                            sw.Write(" " + docInfo.DocScore);
                            sw.WriteLine(" 9370064_8021911_9617051_pancake");
                        }

                        ResultMsg.ForeColor = Color.Green;
                        ResultMsg.Text = "File has been updated successfully";
                    }
                }
            }
        }

        private void BrowseResultButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ResultDirectoryText.Text = @"D:\result.text";
        }
    }
}