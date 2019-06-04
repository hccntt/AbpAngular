using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using angularAbp.Authorization;

namespace angularAbp
{
    [DependsOn(
        typeof(angularAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class angularAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<angularAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(angularAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
