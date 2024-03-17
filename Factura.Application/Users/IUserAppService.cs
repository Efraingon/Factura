using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FacturaApp.Roles.Dto;
using FacturaApp.Users.Dto;

namespace FacturaApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}