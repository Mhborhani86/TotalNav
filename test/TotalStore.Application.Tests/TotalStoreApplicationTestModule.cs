using Volo.Abp.Modularity;

namespace TotalStore;

[DependsOn(
    typeof(TotalStoreApplicationModule),
    typeof(TotalStoreDomainTestModule)
)]
public class TotalStoreApplicationTestModule : AbpModule
{

}
