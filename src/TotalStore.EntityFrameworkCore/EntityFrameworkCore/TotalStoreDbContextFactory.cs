using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TotalStore.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TotalStoreDbContextFactory : IDesignTimeDbContextFactory<TotalStoreDbContext>
{
    public TotalStoreDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        TotalStoreEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<TotalStoreDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new TotalStoreDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TotalStore.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
