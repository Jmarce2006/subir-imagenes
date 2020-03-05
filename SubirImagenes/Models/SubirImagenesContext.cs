using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SubirImagenes.Models
{
    public partial class SubirImagenesContext : DbContext
    {
        public SubirImagenesContext()
        {
        }

        public SubirImagenesContext(DbContextOptions<SubirImagenesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Images> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=SubirImagenes;User Id=sa;Password=sasql");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Images>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ImageTitle).HasMaxLength(50);
            });
        }
    }
}
