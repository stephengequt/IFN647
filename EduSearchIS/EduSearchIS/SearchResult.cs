using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;

namespace EduSearchIS
{
    class SearchResult
    {
        public List<DocInfo> DocInfoList { get; set; }
        public int NumOfResult { get; set; }
        public string finalQuery { get; set; }
    }

    class DocInfo
    {
//        private string Rank { get; set; }
        public Lucene.Net.Documents.Document LuceneDocument { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Bibliography { get; set; }
        public string Sentence { get; set; }
        public string Abstract { get; set; }
        public float DocScore { get; set; }
    }
}
