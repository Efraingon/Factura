using System.Threading.Tasks;
using Abp.Application.Services;
using FacturaApp.Sessions.Dto;

namespace FacturaApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
