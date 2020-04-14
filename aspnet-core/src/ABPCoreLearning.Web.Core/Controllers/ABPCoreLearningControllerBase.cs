using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPCoreLearning.Controllers
{
    public abstract class ABPCoreLearningControllerBase: AbpController
    {
        protected ABPCoreLearningControllerBase()
        {
            LocalizationSourceName = ABPCoreLearningConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
