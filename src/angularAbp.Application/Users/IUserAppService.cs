using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using angularAbp.Roles.Dto;
using angularAbp.Users.Dto;

namespace angularAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
