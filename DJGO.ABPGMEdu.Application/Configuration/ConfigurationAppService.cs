using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DJGO.ABPGMEdu.Configuration.Dto;

namespace DJGO.ABPGMEdu.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPGMEduAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
