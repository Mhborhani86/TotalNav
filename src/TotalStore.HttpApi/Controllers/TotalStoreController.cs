using TotalStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TotalStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TotalStoreController : AbpControllerBase
{
    protected TotalStoreController()
    {
        LocalizationResource = typeof(TotalStoreResource);
    }
}
