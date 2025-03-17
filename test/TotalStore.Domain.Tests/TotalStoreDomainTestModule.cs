using Volo.Abp.Modularity;

namespace TotalStore;

[DependsOn(
    typeof(TotalStoreDomainModule),
    typeof(TotalStoreTestBaseModule)
)]
public class TotalStoreDomainTestModule : AbpModule
{

}
