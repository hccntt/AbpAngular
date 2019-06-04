using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using angularAbp.Configuration;

namespace angularAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(angularAbpWebCoreModule))]
    public class angularAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public angularAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(angularAbpWebHostModule).GetAssembly());
        }
    }
}
