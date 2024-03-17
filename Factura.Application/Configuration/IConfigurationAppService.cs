using System.Threading.Tasks;
using Abp.Application.Services;
using FacturaApp.Configuration.Dto;

namespace FacturaApp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}