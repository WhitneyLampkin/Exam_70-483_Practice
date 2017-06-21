﻿using System;
using System.Diagnostics;

namespace Listing3_54_ReadingDataFromAPerformanceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (CreatePerformanceCounters())
            {
                Console.WriteLine("Created performance coutners");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }

            var totalOperationsCounter = new PerformanceCounter(
                    "MyCategory",
                    "# of operations executed",
                    "",
                    false);

            var operationsPerSecondCounter = new PerformanceCounter(
                    "MyCategory",
                    "# operations / sec",
                    "",
                    false);

            totalOperationsCounter.Increment();
            operationsPerSecondCounter.Increment();
        }

        private static bool CreatePerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection
                {
                    new CounterCreationData("# operations executed",
                                            "Total number of operations executed",
                                            PerformanceCounterType.NumberOfItems32),
                    new CounterCreationData("# operations / sec",
                                            "Number of operations executed per second",
                                            PerformanceCounterType.RateOfCountsPerSecond32)
                };

                // This method isn't used anymore
                // Come back and fix this later
                PerformanceCounterCategory.Create("MyCategory", "Sample category for Codeproject", counters);

                return true;
            }

            return false;
        }
    }
}
