using System;

namespace Listing2_85_UsingWeakReferences
{
    class Program
    {
        static WeakReference data;

        static void Main(string[] args)
        {
            object result = GetData();
            // GC.Collect(); Uncommenting this line will make data.Target null
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if (data.Target == null)
            {
                data.Target = LoadLargeList();
            }

            return data.Target;
        }

        private static object LoadLargeList()
        {
            throw new NotImplementedException();
        }
    }
}
