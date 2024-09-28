using System.Threading.Tasks;

namespace Abp.OnlineStore.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
