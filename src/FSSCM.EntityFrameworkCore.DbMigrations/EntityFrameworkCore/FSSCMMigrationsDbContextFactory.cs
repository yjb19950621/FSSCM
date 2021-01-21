using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FSSCM.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class FSSCMMigrationsDbContextFactory : IDesignTimeDbContextFactory<FSSCMMigrationsDbContext>
    {
        public FSSCMMigrationsDbContext CreateDbContext(string[] args)
        {
            FSSCMEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FSSCMMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FSSCMMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../FSSCM.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
