using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_57_TheIDisposableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Below is the definition of the IDisposable interface
        public interface IDisposable
        {
            // This is the only method in the interface and is used to free up unmanaged resources.

            void Dispose();
        }
    }
}
