using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace baza_vet
{
    internal class VetClinicContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Vaccinations> Vaccinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
        }
    }
}
