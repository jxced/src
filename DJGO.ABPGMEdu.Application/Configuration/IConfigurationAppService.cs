using System.Threading.Tasks;
using Abp.Application.Services;
using DJGO.ABPGMEdu.Configuration.Dto;

namespace DJGO.ABPGMEdu.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}