using Volo.Abp.Modularity;

namespace FSSCM
{
    [DependsOn(
        typeof(FSSCMApplicationModule),
        typeof(FSSCMDomainTestModule)
        )]
    public class FSSCMApplicationTestModule : AbpModule
    {

    }
}