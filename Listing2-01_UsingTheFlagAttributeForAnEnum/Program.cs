using System;

namespace Listing2_01_UsingTheFlagAttributeForAnEnum
{
    class Program
    {
        [Flags]
        enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8, 
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40

        }

        static void Main(string[] args)
        {
            Days readingDays = Days.Monday | Days.Saturday | Days.Sunday;

            Console.WriteLine(readingDays);
            Console.ReadLine();
        }
    }
}
