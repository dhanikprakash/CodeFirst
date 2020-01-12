using System.Data.Entity;

namespace CodeFirstDomain
{
    public class BillingContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Crders { get; set; }
        public DbSet<Address> Addresses{ get; set; }
    }
}
