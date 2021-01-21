﻿using FSSCM.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FSSCM.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FSSCMEntityFrameworkCoreDbMigrationsModule),
        typeof(FSSCMApplicationContractsModule)
        )]
    public class FSSCMDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
