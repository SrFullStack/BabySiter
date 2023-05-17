using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity
{
    public partial class DB_BabySiterContext : DbContext
    {
        public DB_BabySiterContext()
        {
        }

        public DB_BabySiterContext(DbContextOptions<DB_BabySiterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Babysiter> Babysiters { get; set; } = null!;
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; } = null!;
        public virtual DbSet<NeighborhoodBabysiter> NeighborhoodBabysiters { get; set; } = null!;
        public virtual DbSet<RequsetSearchBabysiter> RequsetSearchBabysiters { get; set; } = null!;
        public virtual DbSet<SearchBabysiter> SearchBabysiters { get; set; } = null!;
        public virtual DbSet<Time> Times { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SRV2\\PUPILS;Database=DB_BabySiter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Babysiter>(entity =>
            {
                entity.ToTable("BABYSITER");

                entity.Property(e => e.BabysiterId).HasColumnName("BABYSITER_ID");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.NumOfOpinion).HasColumnName("NUM_OF_OPINION");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<Neighborhood>(entity =>
            {
                entity.ToTable("NEIGHBORHOOD");

                entity.Property(e => e.NeighborhoodId).HasColumnName("NEIGHBORHOOD_ID");

                entity.Property(e => e.NeighborhoodName)
                    .HasMaxLength(50)
                    .HasColumnName("NEIGHBORHOOD_NAME");
            });

            modelBuilder.Entity<NeighborhoodBabysiter>(entity =>
            {
                entity.ToTable("NEIGHBORHOOD_BABYSITER");

                entity.Property(e => e.NeighborhoodBabysiterId).HasColumnName("NEIGHBORHOOD_BABYSITER_ID");

                entity.Property(e => e.BabysiterId).HasColumnName("BABYSITER_ID");

                entity.Property(e => e.NeighborhoodId).HasColumnName("NEIGHBORHOOD_ID");

                entity.HasOne(d => d.Babysiter)
                    .WithMany(p => p.NeighborhoodBabysiters)
                    .HasForeignKey(d => d.BabysiterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NEIGHBORHOOD_BABYSITER_BABYSITER");

                entity.HasOne(d => d.Neighborhood)
                    .WithMany(p => p.NeighborhoodBabysiters)
                    .HasForeignKey(d => d.NeighborhoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NEIGHBORHOOD_BABYSITER_NEIGHBORHOOD");
            });

            modelBuilder.Entity<RequsetSearchBabysiter>(entity =>
            {
                entity.ToTable("REQUSET_SEARCH_BABYSITER");

                entity.Property(e => e.RequsetSearchBabysiterId).HasColumnName("REQUSET_SEARCH_BABYSITER_ID");

                entity.Property(e => e.Day)
                    .HasMaxLength(50)
                    .HasColumnName("DAY");

                entity.Property(e => e.NeighborhoodId).HasColumnName("NEIGHBORHOOD_ID");

                entity.Property(e => e.PartOfDay)
                    .HasMaxLength(50)
                    .HasColumnName("PART_OF_DAY");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.SearchBabysiterId).HasColumnName("SEARCH_BABYSITER_ID");

                entity.HasOne(d => d.Neighborhood)
                    .WithMany(p => p.RequsetSearchBabysiters)
                    .HasForeignKey(d => d.NeighborhoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUSET_SEARCH_BABYSITER_NEIGHBORHOOD");

                entity.HasOne(d => d.SearchBabysiter)
                    .WithMany(p => p.RequsetSearchBabysiters)
                    .HasForeignKey(d => d.SearchBabysiterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUSET_SEARCH_BABYSITER_SEARCH_BABYSITER");
            });

            modelBuilder.Entity<SearchBabysiter>(entity =>
            {
                entity.ToTable("SEARCH_BABYSITER");

                entity.Property(e => e.SearchBabysiterId).HasColumnName("SEARCH_BABYSITER_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.ToTable("TIME");

                entity.Property(e => e.TimeId).HasColumnName("TIME_ID");

                entity.Property(e => e.BabysiterId).HasColumnName("BABYSITER_ID");

                entity.Property(e => e.Day)
                    .HasMaxLength(50)
                    .HasColumnName("DAY");

                entity.Property(e => e.PartOfDay)
                    .HasMaxLength(50)
                    .HasColumnName("PART_OF_DAY");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.HasOne(d => d.Babysiter)
                    .WithMany(p => p.Times)
                    .HasForeignKey(d => d.BabysiterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIME_BABYSITER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
