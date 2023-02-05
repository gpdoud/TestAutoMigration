using System;
using Microsoft.EntityFrameworkCore;

namespace TestAutoMigrartion.Models {

    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder mb) { }
    }
}

