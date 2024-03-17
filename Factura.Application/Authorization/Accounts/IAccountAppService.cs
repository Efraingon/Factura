using System.Threading.Tasks;
using Abp.Application.Services;
using FacturaApp.Authorization.Accounts.Dto;

namespace FacturaApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
