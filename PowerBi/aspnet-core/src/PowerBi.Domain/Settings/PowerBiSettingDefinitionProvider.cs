using Volo.Abp.Settings;

namespace PowerBi.Settings;

public class PowerBiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PowerBiSettings.MySetting1));
    }
}
