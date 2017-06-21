using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_24_ImplementingAnImplicitAndExplicitConversionOperator
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        // User-defined implicit conversion
        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        // User-defined explicit conversion
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}
