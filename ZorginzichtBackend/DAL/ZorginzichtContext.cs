using Microsoft.EntityFrameworkCore;
using ZorginzichtBackend.Models;

namespace ZorginzichtBackend.DAL
{
    public class ZorginzichtContext : DbContext
    {
        public ZorginzichtContext(DbContextOptions options) : base (options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Policy> Policies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // initialise customer data // SEED 
            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, CustomerNumber = 1, Name = "Robin", PolicyID = 1 }
            );

            // initialise policy data // SEED 
            modelBuilder.Entity<Policy>().HasData(
                new Policy { ID = 1, PolicyNr = 1, PolicyName = "Interpolis 1", Insurance = "My insurance", Costs = 120.50f  }
            );
        } 
    }
}
