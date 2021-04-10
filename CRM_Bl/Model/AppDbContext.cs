using CRM_Bl.Model;
using System.Data.Entity;

namespace CRM_Bl
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DBConnection") { }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
