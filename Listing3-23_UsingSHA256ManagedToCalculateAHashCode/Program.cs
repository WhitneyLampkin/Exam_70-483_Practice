﻿using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Listing3_23_UsingSHA256ManagedToCalculateAHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            string data = "A paragraph of text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));

            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));

            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));

            Console.WriteLine(hashA.SequenceEqual(hashB)); // Displays: False
            Console.WriteLine(hashA.SequenceEqual(hashC)); // Displays: True
        }
    }
}
