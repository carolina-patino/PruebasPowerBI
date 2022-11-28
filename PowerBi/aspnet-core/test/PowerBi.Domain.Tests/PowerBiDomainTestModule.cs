using PowerBi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PowerBi;

[DependsOn(
    typeof(PowerBiEntityFrameworkCoreTestModule)
    )]
public class PowerBiDomainTestModule : AbpModule
{

}
