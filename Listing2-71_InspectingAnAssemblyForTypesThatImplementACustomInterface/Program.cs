using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_71_InspectingAnAssemblyForTypesThatImplementACustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly pluginAssembly = Assembly.Load("assemblyname");

            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (var pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
        }
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
