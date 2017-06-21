﻿using System;
using System.Linq;

namespace Listing1_26_UsingForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));

            Console.ReadLine();
        }
    }
}
