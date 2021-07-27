using Microsoft.EntityFrameworkCore;
using ViewCounterExample.Models;

namespace ViewCounterExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<View> Views { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, Title = "Sample Post", Body = "Some Body" });
        }
    }
}
