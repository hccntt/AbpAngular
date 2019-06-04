using System.Threading.Tasks;
using angularAbp.Configuration.Dto;

namespace angularAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
