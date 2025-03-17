using TotalStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TotalStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TotalStoreEntityFrameworkCoreModule),
    typeof(TotalStoreApplicationContractsModule)
)]
public class TotalStoreDbMigratorModule : AbpModule
{
}
