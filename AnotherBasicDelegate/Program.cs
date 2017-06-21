using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBasicDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(Callback);
        }

        //Becomes a delegate to MyClass
        //The real use of delegates in C# is mainly Callbacks
        //It's a representative that allows us to do a callback and data communication

        static void Callback(int i)       
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        public delegate void CallbackDel(int i);
        public void LongRunning(CallbackDel obj)
        {
            for (int i = 0; i < 10000; i++)
            {
                obj(i);
            }
        }
    }
}
