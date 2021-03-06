﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearchIS
{
    class SearchResult
    {
        public List<Lucene.Net.Documents.Document> DocList { get; set; }

        public int NumOfResult { get; set; }


        public SearchResult()
        {

        }
    }

    class DocInfo
    {
//        private string Rank { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Bibliography { get; set; }
        public string Sentence { get; set; }
        public string Abstract { get; set; }
    }
}
