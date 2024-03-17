using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FacturaApp.MultiTenancy.Dto;
using System.Threading.Tasks;

namespace FacturaApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
        Task Delete(EntityDto<int> input);
    }
}
