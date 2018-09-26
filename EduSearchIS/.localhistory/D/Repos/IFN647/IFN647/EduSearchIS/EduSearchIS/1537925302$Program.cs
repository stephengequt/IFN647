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
            List<string> l = new List<string>();
            l.Add("The magical world of oz");
            l.Add("The mad, mad, mad, mad world");
            l.Add("Possum magic");
            l.Add("Mad isn't bad");
            l.Add("Mad's greatest hits");
            

            // Index code
            string indexPath = @"c:\temp\Week6Index";
            myLuceneApp.CreateIndex(indexPath);
            System.Console.WriteLine("Adding Documents to Index");
            int docID = 0;
            foreach (string s in l)
            {

                System.Console.WriteLine("Adding doc " + docID + ". " + s + "  to Index");
                myLuceneApp.IndexText(s);
                docID++;
            }
            System.Console.WriteLine("All documents added.");
            myLuceneApp.CleanUpIndexer();

            // Searching Code
            myLuceneApp.CreateSearcher();
           
            myLuceneApp.SearchText("mad");
            
            // Activity 7
            //myLuceneApp.SearchText("magic");
            
            // Activity 8
            //myLuceneApp.SearchText("mad");
            //myLuceneApp.SearchText("world");
            //myLuceneApp.SearchText("mad world");
            //myLuceneApp.SearchText("\"mad world\"");
            //myLuceneApp.SearchText("\"mad world\" mad world");
            //myLuceneApp.SearchText("mad^2 world");

            // Activity 9
            //myLuceneApp.SearchText("mad");

            myLuceneApp.CleanUpSearcher();


            Console.ReadLine();
        }
    }
}
