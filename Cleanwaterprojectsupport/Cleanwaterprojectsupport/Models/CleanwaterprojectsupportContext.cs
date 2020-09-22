using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cleanwaterprojectsupport.Models
{
    public partial class CleanwaterprojectsupportContext : DbContext
    {
        public CleanwaterprojectsupportContext()
        {
        }

        public CleanwaterprojectsupportContext(DbContextOptions<CleanwaterprojectsupportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Donations> Donations { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        // Unable to generate entity type for table 'dbo.Project'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Feedback'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-ADKNEVB\\SQLEXPRESS;Database=Cleanwaterprojectsupport;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donations>(entity =>
            {
                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DonorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfileId).HasColumnName("UserProfileID");

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("FK__Donations__UserP__4E88ABD4");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.ToTable("User_Profile");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCard)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasColumnName("State/Province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Useraccountid)
                    .IsRequired()
                    .HasColumnName("USERACCOUNTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
