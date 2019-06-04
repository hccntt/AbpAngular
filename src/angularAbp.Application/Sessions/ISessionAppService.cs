using System.Threading.Tasks;
using Abp.Application.Services;
using angularAbp.Sessions.Dto;

namespace angularAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
