using Abp.Application.Services;
using Abp.Application.Services.Dto;
using angularAbp.MultiTenancy.Dto;

namespace angularAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

