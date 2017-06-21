using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_70_CreatingACustomPlug_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class MyPlugin : IPlugin
        {
            public string Name
            {
                get { return "MyPlugin"; }
            }

            public string Description
            {
                get { return "My Sample Plugin"; }
            }
            
            public bool Load(MyApplication application)
            {
                return true;
            }
        }

        public interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(MyApplication application);
        }
    }
}
