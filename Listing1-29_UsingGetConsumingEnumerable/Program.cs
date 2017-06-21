﻿using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Listing1_28_UsingBlockingCollection
{
    public static class Program
    {
        public static void Main()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            Console.ReadLine();
            write.Wait();
        }
    }
}
