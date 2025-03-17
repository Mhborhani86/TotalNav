using Volo.Abp.Settings;

namespace TotalStore.Settings;

public class TotalStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TotalStoreSettings.MySetting1));
    }
}
