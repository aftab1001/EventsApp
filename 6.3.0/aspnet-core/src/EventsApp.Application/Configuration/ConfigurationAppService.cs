using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EventsApp.Configuration.Dto;

namespace EventsApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EventsAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
