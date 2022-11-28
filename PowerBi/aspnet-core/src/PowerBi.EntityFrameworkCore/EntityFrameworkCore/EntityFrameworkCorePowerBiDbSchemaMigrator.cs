using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PowerBi.Data;
using Volo.Abp.DependencyInjection;

namespace PowerBi.EntityFrameworkCore;

public class EntityFrameworkCorePowerBiDbSchemaMigrator
    : IPowerBiDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePowerBiDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PowerBiDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PowerBiDbContext>()
            .Database
            .MigrateAsync();
    }
}
