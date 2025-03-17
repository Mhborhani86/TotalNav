using Volo.Abp.Modularity;

namespace TotalStore;

/* Inherit from this class for your domain layer tests. */
public abstract class TotalStoreDomainTestBase<TStartupModule> : TotalStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
