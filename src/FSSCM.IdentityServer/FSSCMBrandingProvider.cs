using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FSSCM
{
    [Dependency(ReplaceServices = true)]
    public class FSSCMBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FSSCM";
    }
}
