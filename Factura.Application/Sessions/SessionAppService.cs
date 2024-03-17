using System.Threading.Tasks;
using Abp.Auditing;
using AutoMapper;
using FacturaApp.Sessions.Dto;

namespace FacturaApp.Sessions
{
    public class SessionAppService : FacturaAppServiceBase, ISessionAppService
    {
        private readonly IMapper _mapper;
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput();

            if (AbpSession.UserId.HasValue)
            {
                //output.User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>();
                output.User = null;

            }

            if (AbpSession.TenantId.HasValue)
            {
                //output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
                output.Tenant = null;
            }

            return output;
        }
    }
}