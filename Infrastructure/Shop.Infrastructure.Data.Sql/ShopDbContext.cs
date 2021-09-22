using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Data.Sql
{
    public class ShopDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<TechnicalDetail> TechnicalDetails { get; set; }
        public DbSet<UserPage> UserPages { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Comment>().HasIndex(p => p.ProductId).HasDatabaseName("IX_Confirm");

            builder.Entity<Product>().HasIndex(p => p.Titel).HasDatabaseName("IX_Title");
               
        }
    }
}

