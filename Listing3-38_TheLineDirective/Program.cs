using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_38_TheLineDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                #line 200 "OtherFileName"
                    int a;          //line 200
                #line default
                    int b;          // line 4
                #line hidden 
                    int c;          // hidden 
                    int d;          // line 7
            */ 
        }
    }
}
