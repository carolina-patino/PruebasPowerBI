using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PowerBi.Blazor;

[Dependency(ReplaceServices = true)]
public class PowerBiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PowerBi";
}
