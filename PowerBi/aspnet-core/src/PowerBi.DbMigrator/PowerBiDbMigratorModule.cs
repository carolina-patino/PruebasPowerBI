using PowerBi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PowerBi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PowerBiEntityFrameworkCoreModule),
    typeof(PowerBiApplicationContractsModule)
)]
public class PowerBiDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });
    }
}
