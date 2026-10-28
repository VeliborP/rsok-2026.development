using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebShop.MVC.DAL
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext()
        {

        }

        public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
            : base(options)
        {
        }


        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>();
        }
    }
}
