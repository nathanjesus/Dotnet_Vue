using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataCore.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Knight> Knight { get; set; }
        public virtual DbSet<KnightWeapon> KnightWeapon { get; set; }
        public virtual DbSet<Weapon> Weapon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer("Server=NATHAN_LO;Database=Hall;Trusted_Connection=True");
            }

            

     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.Charisma).HasColumnName("charisma");

                entity.Property(e => e.Constitution).HasColumnName("constitution");

                entity.Property(e => e.Dexterity).HasColumnName("dexterity");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.Strength).HasColumnName("strength");

                entity.Property(e => e.Wisdom).HasColumnName("wisdom");
            });

            modelBuilder.Entity<Hall>(entity =>
            {
                entity.HasKey(e => new { e.HallId, e.KnightId });

                entity.Property(e => e.HallId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Knight)
                    .WithMany(p => p.Hall)
                    .HasForeignKey(d => d.KnightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hall_Knight");
            });

            modelBuilder.Entity<Knight>(entity =>
            {
                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Exp).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.KeyAttribute)
                    .HasColumnName("keyAttribute")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.Knight)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_Knight_Attributes");
            });

            modelBuilder.Entity<KnightWeapon>(entity =>
            {
                entity.HasKey(e => new { e.KnightId, e.WeaponId });

                entity.HasOne(d => d.Knight)
                    .WithMany(p => p.KnightWeapon)
                    .HasForeignKey(d => d.KnightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnightWeapon_Knight");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.KnightWeapon)
                    .HasForeignKey(d => d.WeaponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnightWeapon_Weapon");
            });

            modelBuilder.Entity<Weapon>(entity =>
            {
                entity.Property(e => e.Attr)
                    .HasColumnName("attr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipped).HasColumnName("equipped");

                entity.Property(e => e.Mod).HasColumnName("mod");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
