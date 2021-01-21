using FSSCM.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FSSCM.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FSSCMController : AbpController
    {
        protected FSSCMController()
        {
            LocalizationResource = typeof(FSSCMResource);
        }
    }
}