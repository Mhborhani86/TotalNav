using TotalStore.Localization;
using Volo.Abp.Application.Services;

namespace TotalStore;

/* Inherit your application services from this class.
 */
public abstract class TotalStoreAppService : ApplicationService
{
    protected TotalStoreAppService()
    {
        LocalizationResource = typeof(TotalStoreResource);
    }
}
