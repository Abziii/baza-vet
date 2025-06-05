using Microsoft.Extensions.Configuration;
using System.IO;

public class VetClinicContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        string connStr = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(connStr, new MySqlServerVersion(new Version(8, 0, 35)));
    }

    // DbSet<...> itd.
}