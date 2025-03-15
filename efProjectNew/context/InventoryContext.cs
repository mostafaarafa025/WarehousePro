using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using efProjectNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace efProjectNew.context
{
    internal class InventoryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=USER\\SQLEXPRESS;Initial Catalog=EFprojectNew;Integrated Security=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .Property(i=>i.InventoryId)
                .ValueGeneratedNever();
            modelBuilder.Entity<Inventory>().Property(i => i.Name).IsRequired();
            modelBuilder.Entity<Product>()
                .Property(p=>p.ProductId)
                .ValueGeneratedNever();
        }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

    }
}
