using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_49_WritingDataToTheEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }

            EventLog myLog = new EventLog();
            myLog.Source = "My Source";
            myLog.WriteEntry("Log event!");
        }
    }
}
