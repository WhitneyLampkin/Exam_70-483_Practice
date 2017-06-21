using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Listing3_13_DeserializingAnObjectWithTheJavaScriptSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is this not available in C# 6.0
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}
