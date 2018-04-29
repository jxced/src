using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DJGO.ABPGMEdu.Roles.Dto;

namespace DJGO.ABPGMEdu.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
