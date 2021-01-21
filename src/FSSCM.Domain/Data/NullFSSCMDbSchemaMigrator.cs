using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FSSCM.Data
{
    /* This is used if database provider does't define
     * IFSSCMDbSchemaMigrator implementation.
     */
    public class NullFSSCMDbSchemaMigrator : IFSSCMDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}