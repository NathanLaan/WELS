using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WELS.App
{
    internal interface SearchResultOutputHandler
    {

        void AddSearchResult(SearchResult sr);

    }
}
