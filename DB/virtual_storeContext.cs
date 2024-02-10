using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using DB.Models;

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
                string connectionStrign = ConfigurationManager.ConnectionStrings["VirtualStoreConnection"].ConnectionString;
                optionsBuilder.UseMySql(connectionStrign, ServerVersion.Parse("8.0.36-mysql"));
            }
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
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.SaleId).HasColumnName("sale_id");

                entity.Property(e => e.Total)
                    .HasPrecision(9, 3)
                    .HasColumnName("total");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<SalesLine>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.SaleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sales_lines");

                entity.HasIndex(e => e.SaleId, "fk_sale_id_sales");

                entity.Property(e => e.LineId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("line_id");

                entity.Property(e => e.SaleId).HasColumnName("sale_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.SubTotal)
                    .HasPrecision(9, 3)
                    .HasColumnName("subTotal");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalesLines)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sale_id_sales");
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
