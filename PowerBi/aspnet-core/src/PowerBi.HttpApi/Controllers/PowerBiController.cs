using PowerBi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PowerBi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PowerBiController : AbpControllerBase
{
    protected PowerBiController()
    {
        LocalizationResource = typeof(PowerBiResource);
    }
}
