using Volo.Abp.Modularity;

namespace TotalStore;

public abstract class TotalStoreApplicationTestBase<TStartupModule> : TotalStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
