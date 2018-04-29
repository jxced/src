using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DJGO.ABPGMEdu.MultiTenancy.Dto;

namespace DJGO.ABPGMEdu.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
