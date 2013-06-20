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

        public SearchStatusOutputHandler SSOH { get; set; }
        public SearchResultOutputHandler SROH { get; set; }

        public void Start()
        {
        }

        public void Stop()
        {
        }

    }
}
