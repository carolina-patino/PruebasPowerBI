using PowerBi.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PowerBi.Blazor;

public abstract class PowerBiComponentBase : AbpComponentBase
{
    protected PowerBiComponentBase()
    {
        LocalizationResource = typeof(PowerBiResource);
    }
}
