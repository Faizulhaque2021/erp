using erp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace erp.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
           .HasOne(p => p.Category)          // Each Product has one Category
           .WithMany(c => c.Products)        // Each Category has many Products
           .HasForeignKey(p => p.cateId)     // FK in Product
           .IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> users { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Category> categories { get; set; }


    }
}
