using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace angularAbp.Controllers
{
    public abstract class angularAbpControllerBase: AbpController
    {
        protected angularAbpControllerBase()
        {
            LocalizationSourceName = angularAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
