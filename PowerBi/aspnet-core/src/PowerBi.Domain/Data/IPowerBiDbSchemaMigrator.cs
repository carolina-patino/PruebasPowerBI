using System.Threading.Tasks;

namespace PowerBi.Data;

public interface IPowerBiDbSchemaMigrator
{
    Task MigrateAsync();
}
