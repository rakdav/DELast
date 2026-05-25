using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DE.Models;

public partial class De17BdContext : DbContext
{
    public De17BdContext()
    {
    }

    public De17BdContext(DbContextOptions<De17BdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Pv> Pvs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Teacherpc;Initial Catalog=de17BD;User ID=de17;Password=1234;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.Articul).HasMaxLength(6);
            entity.Property(e => e.IdPv).HasColumnName("id_pv");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.ArticulNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Articul)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Product");

            entity.HasOne(d => d.IdPvNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdPv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_PV");

            entity.HasOne(d => d.LoginNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Login)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Users");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Articul);

            entity.ToTable("Product");

            entity.Property(e => e.Articul).HasMaxLength(6);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Manufactor).HasMaxLength(50);
            entity.Property(e => e.NameTovar).HasMaxLength(200);
            entity.Property(e => e.Photo).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Suplier).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<Pv>(entity =>
        {
            entity.HasKey(e => e.IdPv);

            entity.ToTable("PV");

            entity.Property(e => e.IdPv).HasColumnName("id_pv");
            entity.Property(e => e.Address).HasMaxLength(200);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Login);

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.SurName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
