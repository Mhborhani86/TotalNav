using Microsoft.Extensions.Localization;
using TotalStore.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TotalStore;

[Dependency(ReplaceServices = true)]
public class TotalStoreBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TotalStoreResource> _localizer;

    public TotalStoreBrandingProvider(IStringLocalizer<TotalStoreResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
