using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WELS.App
{
    class SearchResult
    {

        public DateTime Timestamp { get; set; }

        public string Message { get; set; }

        public string ReplacementString { get; set; }

        public bool Found { get; set; }

        public SearchResult()
        {
            this.Found = false;
        }

    }
}
