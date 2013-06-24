using System;
using System.Diagnostics;
using System.Threading;

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
            this.threadRunning = true;
            this.eventLogThread = new Thread(new ThreadStart(this.ProcessEventLog));
            this.eventLogThread.Start();
        }

        public void Stop()
        {
            this.threadRunning = false;
        }


        private bool threadRunning;
        private Thread eventLogThread;


        private void ProcessEventLog()
        {
            try
            {
                var log = new EventLog(this.LogName, this.ServerName);
                int count = 0;
                foreach (EventLogEntry entry in log.Entries)
                {
                    if (!threadRunning)
                    {
                        break;
                    }
                    if (this.SSOH != null)
                    {
                        this.SSOH.Update(log.Entries.Count, count++);
                    }
                    
                    SearchResult sr = new SearchResult();

                    if (entry.ReplacementStrings.Length > 0)
                    {
                        if (entry.ReplacementStrings[0].Contains(this.Text))
                        {
                            sr.ReplacementString = entry.ReplacementStrings[0];
                            sr.Found = true;
                            sr.Timestamp = entry.TimeWritten;
                        }
                    }
                    if (entry.Message.Contains(this.Text))
                    {
                        sr.Message = entry.Message;
                        sr.Found = true;
                        sr.Timestamp = entry.TimeWritten;
                    }

                    if (sr.Found)
                    {
                        if (this.SROH != null)
                        {
                            this.SROH.AddSearchResult(sr);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //
            }
        }


    }
}
