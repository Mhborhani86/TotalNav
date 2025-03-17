using Xunit;

namespace TotalStore.EntityFrameworkCore;

[CollectionDefinition(TotalStoreTestConsts.CollectionDefinitionName)]
public class TotalStoreEntityFrameworkCoreCollection : ICollectionFixture<TotalStoreEntityFrameworkCoreFixture>
{

}
