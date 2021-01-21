using FSSCM.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FSSCM
{
    [DependsOn(
        typeof(FSSCMEntityFrameworkCoreTestModule)
        )]
    public class FSSCMDomainTestModule : AbpModule
    {

    }
}