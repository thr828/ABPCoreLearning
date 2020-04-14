using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreLearning.Configuration;

namespace ABPCoreLearning.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPCoreLearningWebCoreModule))]
    public class ABPCoreLearningWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPCoreLearningWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPCoreLearningWebHostModule).GetAssembly());
        }
    }
}
