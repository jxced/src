using System.Threading.Tasks;
using Abp.Application.Services;
using DJGO.ABPGMEdu.Authorization.Accounts.Dto;

namespace DJGO.ABPGMEdu.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
