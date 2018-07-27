using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMTOM.Model
{
    public class tootAMessage
    {
        public Guid id { get; set; }

        public DateTime EntryDateTime { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public string Component { get; set; }

        public bool DownloadedByConsole { get; set; }
        public tootAMessage()
        {

            id = System.Guid.NewGuid();
            DownloadedByConsole = false;
            EntryDateTime = DateTime.Now;
        }
    }
}