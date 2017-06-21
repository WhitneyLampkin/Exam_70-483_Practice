using System.Collections.Generic;

namespace Listing2_43_CreatingAnInterfaceWithAGenericTypeParameter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        interface IRepository<T>
        {
            T FindById(int d);
            IEnumerable<T> All();
        }
    }
}
