using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataRepository.StoredProcedures
{
    public partial class Context : DbContext
    {
        public virtual DbSet<IdentityValues> IdentityValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityValues>(entity =>
            {
                entity.ToTable("IDENTITY_VALUES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
