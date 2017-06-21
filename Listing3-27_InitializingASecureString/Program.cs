using System;
using System.Security;

namespace Listing3_27_InitializingASecureString
{
    class Program
    {
        static void Main(string[] args)
        {
            // SecureString immediately encrypts its value so finding a plain text version is harder
            // SecureString is pinned to a certain place in memory and the Garbage Collector doesn't move it around.
            // Unlike System.String, it's mutable
            // It implements IDisposable

            // The using statement is used so that the secure string doesn't stay in memory longer than necessary.

            using (SecureString ss = new SecureString())
            {
                Console.Write("Please enter your password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    // Each character is appended to the secure string one at a time
                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }

                ss.MakeReadOnly();
            }
        }
    }
}
