using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TotalStore.Data;

/* This is used if database provider does't define
 * ITotalStoreDbSchemaMigrator implementation.
 */
public class NullTotalStoreDbSchemaMigrator : ITotalStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
