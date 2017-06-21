using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Program
    {
        class Shape
        {
            protected int width;
            protected int height;

            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
