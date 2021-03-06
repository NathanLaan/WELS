﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace WELS.App
{
    internal class Search
    {

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.SearchText);
            return sb.ToString();
        }

        public string[] GetItems()
        {
            string[] list = new string[3];
            list[0] = this.SearchText;
            list[1] = this.ServerName;
            list[2] = this.EventLogName;
            return list;
        }
        
        public string SearchText { get; set; }
        public string ServerName { get; set; }
        public string EventLogName { get; set; }
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
                var log = new EventLog(this.EventLogName, this.ServerName);
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
                        if (entry.ReplacementStrings[0].Contains(this.SearchText))
                        {
                            sr.ReplacementString = entry.ReplacementStrings[0];
                            sr.Found = true;
                            sr.Timestamp = entry.TimeWritten;
                        }
                    }
                    if (entry.Message.Contains(this.SearchText))
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
