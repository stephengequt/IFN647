using System.Collections.Generic;

namespace EduSearchBaselineIS
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
        public string DocID { get; set; }
        public int Rank { get; set; } 
        public Lucene.Net.Documents.Document LuceneDocument { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Bibliography { get; set; }
        public string Sentence { get; set; }
        public string Abstract { get; set; }
        public float DocScore { get; set; }
    }

    class QueryInfo
    {
        public string QueryID { get; set; }
        public string QueryContent { get; set; }
    }
}
