using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class DataContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Api.lite.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(b =>
            {
                b.HasKey(m => m.UserID);
                b.HasAlternateKey(m => m.CompanyID);
                b.HasOne(m => m.Company).WithMany(m => m.CompanyUser).IsRequired();
            });

            builder.Entity<Company>(b =>
            {
                b.HasKey(m => m.CompanyID);
                b.Property(m => m.CompanyName).IsRequired();
            });
        }
    }
}
