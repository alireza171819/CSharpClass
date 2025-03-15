using Microsoft.EntityFrameworkCore;
using Model.Domains;

namespace Model.Context
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
        {

        }

        public FinalProjectDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
