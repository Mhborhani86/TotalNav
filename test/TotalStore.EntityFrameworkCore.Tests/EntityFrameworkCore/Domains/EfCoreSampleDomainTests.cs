using TotalStore.Samples;
using Xunit;

namespace TotalStore.EntityFrameworkCore.Domains;

[Collection(TotalStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TotalStoreEntityFrameworkCoreTestModule>
{

}
