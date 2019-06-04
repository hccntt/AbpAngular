using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using angularAbp.Configuration.Dto;

namespace angularAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : angularAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
