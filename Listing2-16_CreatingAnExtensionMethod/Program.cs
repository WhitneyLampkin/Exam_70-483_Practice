namespace Listing2_16_CreatingAnExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    // Below is the extension method which has to be a 
    // Static method
    // Within a static class
    // And the 1st param names the type to extend with the 'this' keyword
    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            // Now we can pass in an instance of Product
            // And call the Discount method as if it were defined in the Product class itself

            return p.Discount();
        }
    }
}
