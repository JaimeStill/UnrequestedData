using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnrequestedData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var ent in modelBuilder.Model.GetEntityTypes().Select(x => x.Name))
            {
                modelBuilder.Entity(ent).ToTable(ent.Split('.').Last());
            }
        }
    }
}
