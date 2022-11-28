using PowerBi.Localization;
using Volo.Abp.Application.Services;

namespace PowerBi;

/* Inherit your application services from this class.
 */
public abstract class PowerBiAppService : ApplicationService
{
    protected PowerBiAppService()
    {
        LocalizationResource = typeof(PowerBiResource);
    }
}
