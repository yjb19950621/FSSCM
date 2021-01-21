using System;
using System.Collections.Generic;
using System.Text;
using FSSCM.Localization;
using Volo.Abp.Application.Services;

namespace FSSCM
{
    /* Inherit your application services from this class.
     */
    public abstract class FSSCMAppService : ApplicationService
    {
        protected FSSCMAppService()
        {
            LocalizationResource = typeof(FSSCMResource);
        }
    }
}
