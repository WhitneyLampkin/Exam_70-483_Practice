using System.Reflection;

namespace Listing2_60_SpecifyingTheTargetOfAnAttributeExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class MultipleAttributes
    {
        // I'm not sure how to use these correctly to get the syntax right
        // Note to self: Look this up later
        // "Ain't nobody got time for it right now"

        [assembly: AssemblyTitle("ClassLibrary1")]
        [assembly: AssemblyDescription("")]
        [assembly: AssemblyConfiguration("")]
        [assembly: AssemblyCompany("")]
        [assembly: AssemblyProduct("ClassLibrary1")]
        [assembly: AssemblyCopyright("Copyright 2013")]
        [assembly: AssemblyTrademark("")]
        [assembly: AssemblyCulture("")]
    }
}
