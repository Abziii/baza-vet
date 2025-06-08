using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using baza_vet.Modele;

namespace baza_vet.Data
{
    public class VetClinicContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Vaccinations> Vaccinations { get; set; }
        public DbSet<Appointments> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // tabela pośrednia do relacji N:N
            modelBuilder.Entity<Animal>()
                .HasMany(a => a.doctors)
                .WithMany(d => d.pacjents)
                .UsingEntity(j => j.ToTable("animal_doctors"));

            modelBuilder.Entity<Vaccinations>()
                .HasOne(v => v.animal)
                .WithMany(a => a.vaccinations)
                .HasForeignKey(v => v.Animal_Id);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.animal)
                .WithMany(a => a.appointments)
                .HasForeignKey(a => a.Animal_Id);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.doctor)
                .WithMany()
                .HasForeignKey(a => a.Doctor_Id);
  
        }
    }
}
