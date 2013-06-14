using System;
using System.Diagnostics;

namespace WELS.App
{
    class Search
    {

        public string ServerName { get; set; }
        public string LogName { get; set; }
        public string Text { get; set; }
        public EventLogEntryType LogType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
