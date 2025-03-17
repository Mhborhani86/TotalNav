using System.Threading.Tasks;

namespace TotalStore.Data;

public interface ITotalStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
