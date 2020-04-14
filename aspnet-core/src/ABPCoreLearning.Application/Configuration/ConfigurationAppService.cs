using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPCoreLearning.Configuration.Dto;

namespace ABPCoreLearning.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPCoreLearningAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
