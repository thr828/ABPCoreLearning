using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPCoreLearning.Web.Views
{
    public abstract class ABPCoreLearningViewComponent : AbpViewComponent
    {
        protected ABPCoreLearningViewComponent()
        {
            LocalizationSourceName = ABPCoreLearningConsts.LocalizationSourceName;
        }
    }
}
