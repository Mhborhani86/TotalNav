using TotalStore.Samples;
using Xunit;

namespace TotalStore.EntityFrameworkCore.Applications;

[Collection(TotalStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TotalStoreEntityFrameworkCoreTestModule>
{

}
