using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TotalStore.Data;
using Volo.Abp.DependencyInjection;

namespace TotalStore.EntityFrameworkCore;

public class EntityFrameworkCoreTotalStoreDbSchemaMigrator
    : ITotalStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTotalStoreDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TotalStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TotalStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
