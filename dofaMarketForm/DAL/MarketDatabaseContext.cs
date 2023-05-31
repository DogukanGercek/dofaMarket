using System;
using System.Collections.Generic;
using dofaMarketForm.Models;
using Microsoft.EntityFrameworkCore;

namespace dofaMarketForm.DAL;

public partial class MarketDatabaseContext : DbContext
{
    public MarketDatabaseContext()
    {
    }

    public MarketDatabaseContext(DbContextOptions<MarketDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth> Auths { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Fatura> Faturas { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`;TrustServerCertificate=True");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auth>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__auth__1788CC4C1E1B72C6");

            entity.ToTable("auth");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userType");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2B9FD3EA4A");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BirthDate).HasMaxLength(50);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.HireDate).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Salary).HasMaxLength(50);
            entity.Property(e => e.Tel).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Fatura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fatura__3214EC0706D782BC");

            entity.ToTable("fatura");

            entity.Property(e => e.PUstu)
                .HasColumnType("money")
                .HasColumnName("pUstu");
            entity.Property(e => e.Toplam)
                .HasColumnType("money")
                .HasColumnName("toplam");
            entity.Property(e => e.VerilenPara)
                .HasColumnType("money")
                .HasColumnName("verilenPara");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CD5A6142C6");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.Supplier).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
