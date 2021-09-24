using IndecisiveApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IndecisiveApp.Data
{
    public class IndecisiveContext : DbContext
    {
        public IndecisiveContext(DbContextOptions<IndecisiveContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set;  }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Tag>().ToTable("Tag");
        }
    }
}
