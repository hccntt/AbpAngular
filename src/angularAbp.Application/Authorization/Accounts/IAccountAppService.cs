using System.Threading.Tasks;
using Abp.Application.Services;
using angularAbp.Authorization.Accounts.Dto;

namespace angularAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
