using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ABPCoreLearning.Web.Views
{
    public abstract class ABPCoreLearningRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPCoreLearningRazorPage()
        {
            LocalizationSourceName = ABPCoreLearningConsts.LocalizationSourceName;
        }
    }
}
