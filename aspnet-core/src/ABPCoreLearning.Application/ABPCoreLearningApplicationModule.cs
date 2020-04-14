using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreLearning.Authorization;

namespace ABPCoreLearning
{
    [DependsOn(
        typeof(ABPCoreLearningCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPCoreLearningApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPCoreLearningAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPCoreLearningApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
