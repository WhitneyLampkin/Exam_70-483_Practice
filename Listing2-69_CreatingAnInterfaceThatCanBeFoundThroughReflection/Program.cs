using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_69_CreatingAnInterfaceThatCanBeFoundThroughReflection
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(MyApplication application);
    }
}
