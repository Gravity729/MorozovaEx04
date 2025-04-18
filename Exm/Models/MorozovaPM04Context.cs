using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class MorozovaPM04Context : DbContext
    {
        public MorozovaPM04Context()
        {
        }

        public MorozovaPM04Context(DbContextOptions<MorozovaPM04Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AssortmentPizza> AssortmentPizza { get; set; }
        public virtual DbSet<OrdersAssortment> OrdersAssortment { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<SizePizza> SizePizza { get; set; }
        public virtual DbSet<WeightPizza> WeightPizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=hqvla3302s01\\KITP;Database=MorozovaPM04;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssortmentPizza>(entity =>
            {
                entity.HasKey(e => e.IdAssortmentPizza);

                entity.ToTable("Assortment_Pizza");

                entity.Property(e => e.IdAssortmentPizza)
                    .HasColumnName("ID_Assortment_Pizza")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPizza).HasColumnName("ID_Pizza");

                entity.Property(e => e.IdSizePizza).HasColumnName("ID_Size_Pizza");

                entity.Property(e => e.IdWeightPizza).HasColumnName("ID_Weight_Pizza");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.AssortmentPizza)
                    .HasForeignKey(d => d.IdPizza)
                    .HasConstraintName("FK_Assortment_Pizza_Pizza");

                entity.HasOne(d => d.IdSizePizzaNavigation)
                    .WithMany(p => p.AssortmentPizza)
                    .HasForeignKey(d => d.IdSizePizza)
                    .HasConstraintName("FK_Assortment_Pizza_Size_Pizza");

                entity.HasOne(d => d.IdWeightPizzaNavigation)
                    .WithMany(p => p.AssortmentPizza)
                    .HasForeignKey(d => d.IdWeightPizza)
                    .HasConstraintName("FK_Assortment_Pizza_Weight_Pizza");
            });

            modelBuilder.Entity<OrdersAssortment>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Orders_Assortment");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_Order")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOrder)
                    .HasColumnName("Date_Order")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.IdAssortmentPizza).HasColumnName("ID_Assortment_Pizza");

                entity.Property(e => e.Lastname).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Room).HasMaxLength(255);

                entity.Property(e => e.Street).HasMaxLength(255);

                entity.Property(e => e.Surname).HasMaxLength(255);

                entity.HasOne(d => d.IdAssortmentPizzaNavigation)
                    .WithMany(p => p.OrdersAssortment)
                    .HasForeignKey(d => d.IdAssortmentPizza)
                    .HasConstraintName("FK_Orders_Assortment_Assortment_Pizza");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza);

                entity.Property(e => e.IdPizza)
                    .HasColumnName("ID_Pizza")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ingredients).HasMaxLength(255);

                entity.Property(e => e.NamePizza)
                    .HasColumnName("Name_Pizza")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SizePizza>(entity =>
            {
                entity.HasKey(e => e.IdSizePizza);

                entity.ToTable("Size_Pizza");

                entity.Property(e => e.IdSizePizza)
                    .HasColumnName("ID_Size_Pizza")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameSize)
                    .HasColumnName("Name_Size")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WeightPizza>(entity =>
            {
                entity.HasKey(e => e.IdWeightPizza);

                entity.ToTable("Weight_Pizza");

                entity.Property(e => e.IdWeightPizza)
                    .HasColumnName("ID_Weight_Pizza")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameWeight).HasColumnName("Name_Weight");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
