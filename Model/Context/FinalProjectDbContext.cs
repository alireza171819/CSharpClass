using Microsoft.EntityFrameworkCore;
using Model.Domains;

namespace Model.Context
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
