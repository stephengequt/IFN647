using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearchIS
{
    class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Lucene.Net");

            LuceneAdvancedSearchApplication myLuceneApp = new LuceneAdvancedSearchApplication();

            // source collection
            string path = @"D:\Google Drive\QUT\Sem4\IFN647 Advanced Information Storage and Retrieval\Assessment2\collection";
            WalkDirectoryTree(path);
//            List<string> l = new List<string>();
//            l.Add("The magical world of oz");
//            l.Add("The mad, mad, mad, mad world");
//            l.Add("Possum magic");
//            l.Add("Mad isn't bad");
//            l.Add("Mad's greatest hits");
            

//            // Index code
//            string indexPath = @"c:\temp\Week6Index";
//            myLuceneApp.CreateIndex(indexPath);
//            System.Console.WriteLine("Adding Documents to Index");
//            int docID = 0;
//            foreach (string s in l)
//            {
//
//                System.Console.WriteLine("Adding doc " + docID + ". " + s + "  to Index");
//                myLuceneApp.IndexText(s);
//                docID++;
//            }
//            System.Console.WriteLine("All documents added.");
//            myLuceneApp.CleanUpIndexer();
//
//            // Searching Code
//            myLuceneApp.CreateSearcher();
//           
//            myLuceneApp.SearchText("mad");
//            
//            // Activity 7
//            //myLuceneApp.SearchText("magic");
//            
//            // Activity 8
//            //myLuceneApp.SearchText("mad");
//            //myLuceneApp.SearchText("world");
//            //myLuceneApp.SearchText("mad world");
//            //myLuceneApp.SearchText("\"mad world\"");
//            //myLuceneApp.SearchText("\"mad world\" mad world");
//            //myLuceneApp.SearchText("mad^2 world");
//
//            // Activity 9
//            //myLuceneApp.SearchText("mad");
//
//            myLuceneApp.CleanUpSearcher();


            Console.ReadLine();
        }

        static void OutputFileDetails(string name) { 
            char[] delims = {' ', '\n'};
            System.IO.StreamReader reader = new System.IO.StreamReader(name);
            string text = "";
            string line = "";
            int numWords = 0;
            while ((line = reader.ReadLine()) != null)
            {
                numWords += line.Split(delims, StringSplitOptions.RemoveEmptyEntries).Count();
            }
            reader.Close();

            Console.WriteLine("Fileame " + name + " Word Count " + numWords);

        }

        static void WalkDirectoryTree(String path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder 
            try
            {
                files = root.GetFiles("*.*");
            }

            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    string name = fi.FullName;
                    OutputFileDetails(name);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    string name = dirInfo.FullName;
                    WalkDirectoryTree(name);
                }
            }
        }
    }
}
