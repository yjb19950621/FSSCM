using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FSSCM.Data;
using Volo.Abp.DependencyInjection;

namespace FSSCM.EntityFrameworkCore
{
    public class EntityFrameworkCoreFSSCMDbSchemaMigrator
        : IFSSCMDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFSSCMDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FSSCMMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FSSCMMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}