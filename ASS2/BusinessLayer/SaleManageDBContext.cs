using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BusinessLayer
{
    public partial class SaleManageDBContext : DbContext
    {
        public SaleManageDBContext() { }
        public SaleManageDBContext(DbContextOptions<SaleManageDBContext> options) : base(options)
        {


        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Sale_Manage;User Id=sa;Password=12345;TrustServerCertificate=True;");
        }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.MemberId).HasColumnName("MemberId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Email).HasColumnName("Email").HasColumnType("varchar(100)").IsRequired();
                entity.Property(e => e.CompanyName).HasColumnName("CompanyName").HasColumnType("varchar(40)");
                entity.Property(e => e.City).HasColumnName("City").HasColumnType("varchar(15)");
                entity.Property(e => e.Country).HasColumnName("Country").HasColumnType("varchar(15)");
                entity.Property(e => e.Password).HasColumnName("Password").HasColumnType("varchar(30)").IsRequired();

                entity.HasKey(e => e.MemberId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");

                entity.Property(e => e.Orderid).HasColumnName("OrderId").HasColumnType("int").IsRequired();
                entity.Property(e => e.MemberId).HasColumnName("MemberId").HasColumnType("int").IsRequired();
                entity.Property(e => e.OrderDate).HasColumnName("OrderDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.RequiredDate).HasColumnName("RequiredDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.ShippedDate).HasColumnName("ShippedDate").HasColumnType("datetime").IsRequired();
                entity.Property(e => e.Freight).HasColumnName("Freight").HasColumnType("money").IsRequired();

                entity.HasKey(e => e.Orderid);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductId").HasColumnType("int").IsRequired();
                entity.Property(e => e.CategoryId).HasColumnName("CategoryId").HasColumnType("int").IsRequired();
                entity.Property(e => e.ProductName).HasColumnName("ProductName").HasColumnType("varchar(40)").IsRequired();
                entity.Property(e => e.Weight).HasColumnName("Weight").HasColumnType("varchar(20)");
                entity.Property(e => e.UnitPrice).HasColumnName("UnitPrice").HasColumnType("money").IsRequired();
                entity.Property(e => e.UnitsStock).HasColumnName("UnitsInStock").HasColumnType("int").IsRequired();

                entity.HasKey(e => e.ProductId);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Orderid).HasColumnName("OrderId").HasColumnType("int").IsRequired();
                entity.Property(e => e.Productid).HasColumnName("ProductId").HasColumnType("int").IsRequired();
                entity.Property(e => e.UnitPrice).HasColumnName("UnitPrice").HasColumnType("money").IsRequired();
                entity.Property(e => e.Quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();
                entity.Property(e => e.Discount).HasColumnName("Discount").HasColumnType("float").IsRequired();

                entity.HasKey(e => new { e.Orderid, e.Productid });

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.Orderid);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.Productid);
            });
        }
    }
}

