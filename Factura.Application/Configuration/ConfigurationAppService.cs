using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FacturaApp.Configuration.Dto;

namespace FacturaApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FacturaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
