using System.Threading.Tasks;
using Abp.Application.Services;
using DJGO.ABPGMEdu.Sessions.Dto;

namespace DJGO.ABPGMEdu.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
