using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_64_CreatingACustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //[Fact]
        //[Trait("Category", "Unit Test")]
        //public void MyUnitTest() { }

        //[Fact]
        //[Trait("Category", "Integration Test")]
        //public void MyIntegrationTest() { }
    }
    
    // This would be used with xUnit
    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string value) : base("Category", value) { }
    }

    public class UnitTestAttribute : CategoryAttribute
    {
        public UnitTestAttribute(string value) : base(value)
        {
        }

        public UnitTestAttribute() : base("Unit Test") { }
    }
}
