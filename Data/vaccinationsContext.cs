using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace vaccinated_bank.Data
{
    public partial class vaccinationsContext : DbContext
    {
        public vaccinationsContext()
        {
        }

        public vaccinationsContext(DbContextOptions<vaccinationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<Vaccinated> Vaccinateds { get; set; } = null!;
        public virtual DbSet<Vaccine> Vaccines { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;uid;pwd;database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("PRIMARY");

                entity.ToTable("provinces");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.Province1)
                    .HasMaxLength(50)
                    .HasColumnName("province");
            });

            modelBuilder.Entity<Vaccinated>(entity =>
            {
                entity.ToTable("vaccinated");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate).HasColumnName("birth_date");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(50)
                    .HasColumnName("cedula");

                entity.Property(e => e.DateVaccine).HasColumnName("date_vaccine");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .HasColumnName("province");

                entity.Property(e => e.Vaccine)
                    .HasMaxLength(20)
                    .HasColumnName("vaccine");

                entity.Property(e => e.ZodiacSign)
                    .HasMaxLength(50)
                    .HasColumnName("zodiac_sign");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.HasKey(e => e.Idvaccine)
                    .HasName("PRIMARY");

                entity.ToTable("vaccines");

                entity.Property(e => e.Idvaccine).HasColumnName("idvaccine");

                entity.Property(e => e.Vaccine1)
                    .HasMaxLength(50)
                    .HasColumnName("vaccine");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
