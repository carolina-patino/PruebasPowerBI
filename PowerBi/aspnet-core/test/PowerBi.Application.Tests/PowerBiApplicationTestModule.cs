using Volo.Abp.Modularity;

namespace PowerBi;

[DependsOn(
    typeof(PowerBiApplicationModule),
    typeof(PowerBiDomainTestModule)
    )]
public class PowerBiApplicationTestModule : AbpModule
{

}
