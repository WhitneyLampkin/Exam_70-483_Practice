using System.Collections.Generic;

namespace Listing3_21_ANaiveSetImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a BAD example on purpose. It doesn't scale well and leaves to performance problems. 
        }
    }

    class Set<T>
    {
        private List<T> list = new List<T>();

        public void Insert(T item)
        {
            if (!Contains(item)) list.Add(item);
        }

        public bool Contains(T item)
        {
            foreach (T member in list)
            {
                if (member.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
