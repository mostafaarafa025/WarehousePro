using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

            modelBuilder.Entity<InventoryItems>()
                .HasKey(ii => new {ii.InventoryId,ii.ProductId});

            modelBuilder.Entity<InventoryItems>()
           .Property(ii => ii.Quantity)
           .IsRequired()
           .HasDefaultValue(0);
               
                
              modelBuilder.Entity<InventoryItems>()
             .HasOne(ii => ii.Inventory)
             .WithMany(i => i.InventoryItems)
             .HasForeignKey(ii => ii.InventoryId)
             .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<InventoryItems>()
                    .HasOne(ii => ii.Product)
                    .WithMany(p => p.InventoryItems)
                    .HasForeignKey(ii => ii.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EntryVoucher>()
         .HasKey(ev => ev.referenceNumber); 

            modelBuilder.Entity<EntryVoucher>()
                .Property(ev => ev.Date)
                .IsRequired(); 

            modelBuilder.Entity<EntryVoucher>()
                .HasOne(ev => ev.Supplier)
                .WithMany()
                .HasForeignKey(ev => ev.SupplierId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<EntryVoucher>()
                .HasOne(ev => ev.Inventory)
                .WithMany()
                .HasForeignKey(ev => ev.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<EntryVoucherDetail>()
           .HasKey(evd => new { evd.ReferenceNumber, evd.ProductId }); 

            modelBuilder.Entity<EntryVoucherDetail>()
                .HasOne(evd => evd.EntryVoucher)
                .WithMany(ev => ev.EntryVoucherDetails)
                .HasForeignKey(evd => evd.ReferenceNumber);

            modelBuilder.Entity<EntryVoucherDetail>()
                .HasOne(evd => evd.Product)
                .WithMany(p => p.EntryVoucherDetails)
                .HasForeignKey(evd => evd.ProductId);

        }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<InventoryItems> InventoryItems { get; set; }
        public virtual DbSet<EntryVoucher> EntryVouchers { get; set; }
        public DbSet<EntryVoucherDetail> EntryVoucherDetails { get; set; }

    }
}
