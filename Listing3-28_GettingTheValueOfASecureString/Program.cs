using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Listing3_28_GettingTheValueOfASecureString
{
    class Program
    {
        static void Main(string[] args)
        {
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
                }

                ss.MakeReadOnly();
                ConvertToUnsecureString(ss);
            }


        }

        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {

                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        public SecureString GetSecureString()
        {
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
                }

                ss.MakeReadOnly();
                return ss;
            }
        }
    }
}
