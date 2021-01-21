using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FSSCM.EntityFrameworkCore
{
    [DependsOn(
        typeof(FSSCMEntityFrameworkCoreModule)
        )]
    public class FSSCMEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FSSCMMigrationsDbContext>();
        }
    }
}
