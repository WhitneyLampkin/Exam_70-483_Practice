using Listing3_1_CustomerAndAddressClasses;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace Listing3_2_SavingANewCustomerToTheDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // This example isn't connected to a database...


            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                Customer c = new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a
                };

                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }
    }

    public class ShopContext : Context
    {
        public ISet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Make sure the database knows how to handle the duplicate address property

            modelBuilder.Entity<Customer>().HasRequired(bm.BillingAddress).WithMany().WillCascadeOnDelete(false);
        }
    }
}
