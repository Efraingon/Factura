using System.Collections.Generic;
using FacturaApp.Roles.Dto;
using FacturaApp.Users.Dto;

namespace FacturaApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}