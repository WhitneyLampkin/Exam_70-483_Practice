using System;

namespace BasicDelegate
{
    class Program
    {
        public delegate void SomeMethodPtr();

        static void Main(string[] args)
        {
            SomeMethodPtr obj = new SomeMethodPtr(SomeMethod);

            obj.Invoke();
        }

        static void SomeMethod()
        {
            Console.WriteLine("SomeMethod was called.");
            Console.ReadLine();
        }
    }
}
