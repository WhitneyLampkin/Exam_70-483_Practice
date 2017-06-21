using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_51_WritingDataToTheEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            Console.ReadKey();
        }
    }
}
