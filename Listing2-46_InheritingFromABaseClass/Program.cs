using System.Collections.Generic;
using System.Linq;

namespace Listing2_46_InheritingFromABaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Order : IEntity
        {
            public int Id { get; set; }
            // Other implmentation details omitted
            // ...
        }

        class OrderRepository : Repository<Order>
        {
            public OrderRepository(IEnumerable<Order> orders) : base(orders) { }

            public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
            {
                List<Order> result = null;

                // Some filtering code
                return result;
            }
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
