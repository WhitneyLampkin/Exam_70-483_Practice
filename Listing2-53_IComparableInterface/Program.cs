using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_53_IComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        // The IComparable interface is defined as below. 
        // It's used to sort elements. 
        // The CompareTo method returns an int value that shows how two elements are related.
        public interface IComparable
        {
            int CompareTo(Object obj);
        }
    }
}
