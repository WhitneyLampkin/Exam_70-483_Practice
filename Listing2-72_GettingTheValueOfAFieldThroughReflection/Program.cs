using System;
using System.Reflection;

namespace Listing2_72_GettingTheValueOfAFieldThroughReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }
}
