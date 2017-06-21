﻿using System;

namespace Listing2_99_ImplementingCustomFormattingOnAType
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format == "G")
            {
                format = "FL";
            }

            format = format.Trim().ToUpperInvariant();

            switch (format)
            {
                case "FL":
                    return FirstName + " " + LastName;
                case "LF":
                    return LastName + " " + FirstName;
                case "FSL":
                    return FirstName + ", " + LastName;
                case "LSF":
                    return LastName + ", " + FirstName;
                default:
                    throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
            }
        }
    }
}
