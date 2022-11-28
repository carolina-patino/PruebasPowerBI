using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PowerBi.Data;

/* This is used if database provider does't define
 * IPowerBiDbSchemaMigrator implementation.
 */
public class NullPowerBiDbSchemaMigrator : IPowerBiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
