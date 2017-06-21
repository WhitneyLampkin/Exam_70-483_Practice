using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_45_CreatingABaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        interface IEntity
        {
            int Id { get; set; }
        }

        class Repository<T> where T : IEntity
        {
            protected IEnumerable<T> _elements;

            public Repository(IEnumerable<T> elements)
            {
                _elements = elements;
            }

            public T FindById(int id)
            {
                return _elements.SingleOrDefault(e => e.Id == id);
            }
        }
    }
}
