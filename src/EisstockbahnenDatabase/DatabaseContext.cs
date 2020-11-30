using System;
using EisstockbahnenDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace EisstockbahnenDatabase
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=dbbrpinf.database.windows.net;Initial Catalog=db_eistockbahnen;User ID=sdl;Password=wurmtreter66ecoWIN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary Keys
            modelBuilder.Entity<Unit>().HasKey(a => a.Id).HasName("PKUNIT");
            modelBuilder.Entity<Product>().HasKey(a => a.Id).HasName("PKPRODUCT");
            modelBuilder.Entity<Account>().HasKey(a => a.Id).HasName("PKACCOUNT");

            // Releations 
            modelBuilder.Entity<Product>().HasOne(p => p.Unit).WithMany(u => u.Products);

            // Auto Increment Id on each table
            modelBuilder.Entity<Unit>().Property(u => u.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Account>().Property(a => a.Id).ValueGeneratedOnAdd();
        }
    }
}
