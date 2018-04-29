using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DJGO.ABPGMEdu.Roles.Dto;
using DJGO.ABPGMEdu.Users.Dto;

namespace DJGO.ABPGMEdu.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}