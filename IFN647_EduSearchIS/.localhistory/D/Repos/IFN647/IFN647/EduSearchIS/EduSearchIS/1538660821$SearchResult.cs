using System;
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
}
