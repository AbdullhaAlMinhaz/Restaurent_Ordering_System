using Microsoft.EntityFrameworkCore;
using Restaurent_Ordering_System.Models;  // <-- your models namespace

namespace Restaurent_Ordering_System.Data   // <-- match your project namespace
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        // optional: override OnModelCreating if you need custom configuration later
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        // }
    }
}
