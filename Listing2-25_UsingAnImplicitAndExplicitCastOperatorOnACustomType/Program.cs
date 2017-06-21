using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_25_UsingAnImplicitAndExplicitCastOperatorOnACustomType
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;

            Console.WriteLine(truncatedAmount);
        
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
}
