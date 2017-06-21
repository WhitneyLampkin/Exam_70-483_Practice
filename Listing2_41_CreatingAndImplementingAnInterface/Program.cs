using System;

namespace Listing2_41_CreatingAndImplementingAnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var ei = new ExampleImplementation();

            var s = ei.GetResult();

            Console.WriteLine($"The result is {s} and I wrote this using string interpolation. Yay me!");
        }

        interface IExample
        {
            string GetResult();
            int Value { get; set; }
            event EventHandler ResultRetrieved;
            int this[string index] { get; set; }
        }

        class ExampleImplementation : IExample
        {
            public string GetResult()
            {
                return "result";
            }

            public int Value { get; set; }
            public event EventHandler CalculationPerformed;
            public event EventHandler ResultRetrieved;
            public int this[string index]
            {
                get
                {
                    return 42;
                }
                set { }
            }
        }
    }
}
