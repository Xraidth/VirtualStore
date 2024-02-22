using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using EF.Models;
using System.Configuration.Provider;
using Microsoft.Extensions.Configuration;


namespace DB
{
    public partial class virtual_storeContext : DbContext
    {
        public virtual_storeContext()
        {
        }

        public virtual_storeContext(DbContextOptions<virtual_storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SalesLine> SalesLines { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();

                string connectionString = configuration.GetConnectionString("MyDatabaseConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("8.0.36-mysql"));
            }
        }

        public static virtual_storeContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<virtual_storeContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();

            string connectionString = configuration.GetConnectionString("MyDatabaseConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("8.0.36-mysql"));

            var options = optionsBuilder.Options;

            var context = new virtual_storeContext(options);

            if (!context.Database.CanConnect())
            {
                context.Database.Migrate();
            }

            return context;
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasPrecision(9, 3)
                    .HasColumnName("product_price");

                entity.Property(e => e.ProductStock)
                 .IsRequired()
                .HasColumnType("INT")
                .HasAnnotation("CheckConstraint", "CHECK (product_stock >= 0)")
                .HasColumnName("product_stock");

            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.SaleId).HasColumnName("sale_id");

                entity.HasIndex(e => e.UserId, "fk_user_id_users");

                entity.Property(e => e.Total)
                    .HasPrecision(9, 3)
                    .HasColumnName("total");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.SaleDay)
                    .HasColumnType("date")
                    .HasColumnName("sale_day");

                entity.HasOne(d => d.User)
                  .WithMany()
                  .HasForeignKey(d => d.UserId)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasConstraintName("fk_user_id_users");

            });

            modelBuilder.Entity<SalesLine>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.SaleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sales_lines");

                entity.HasIndex(e => e.SaleId, "fk_sale_id_sales");

                entity.HasIndex(e => e.ProductId, "fk_product_id_products");

                entity.Property(e => e.LineId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("line_id");

                entity.Property(e => e.SaleId).HasColumnName("sale_id");
                
                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.SubTotal)
                    .HasPrecision(9, 3)
                    .HasColumnName("subTotal");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalesLines)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_sale_id_sales");

                entity.HasOne(d => d.Product)
                    .WithMany() 
                    .HasForeignKey(d => d.ProductId) 
                    .OnDelete(DeleteBehavior.Cascade) 
                    .HasConstraintName("fk_product_id_products"); 

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .HasColumnName("user_password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
