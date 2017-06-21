using System;

namespace Listing2_42_AddingASetAccessorToAnImplementedInterfaceProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var rwi = new ReadAndWriteImplemetation();

            rwi.Value = 1987478292;

            Console.WriteLine(rwi.Value);
            Console.ReadLine();
        }

        interface IReadOnlyInterface
        {
            int Value { get; }
        }

        struct ReadAndWriteImplemetation : IReadOnlyInterface
        {
            public int Value { get; set; }
        }
    }
}
