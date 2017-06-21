using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_15_UsingDefault_T_WithAGenericTypeParameter
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
        }
    }
}
