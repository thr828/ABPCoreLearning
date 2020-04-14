using System.Threading.Tasks;
using ABPCoreLearning.Configuration.Dto;

namespace ABPCoreLearning.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
