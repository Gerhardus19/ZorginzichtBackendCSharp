using Microsoft.EntityFrameworkCore;
using ZorginzichtBackend.Models;

namespace ZorginzichtBackend.DAL
{
    public class ZorginzichtContext : DbContext
    {
        public ZorginzichtContext(DbContextOptions options) : base (options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, CustomerNumber = 1, Name = "Robin", PolicyID = 1 }
            ) ; 
        } 
    }
}
