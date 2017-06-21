using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_36_UsingPreprocessorDirectivesToTargetMultiplePlatforms
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public Assembly LoadAssembly<T>()
        {
            /* 
                #if !WINRT
                    Asembly assembly = typeof(T).Assembly;
                #else
                    Assembly assembly = typeof(T).GetTypeInfo().Assembly;
                #endif

            return assembly;
            */ 
        }
    }
}
