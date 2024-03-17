using System.Collections.Generic;
using FacturaApp.Roles.Dto;

namespace FacturaApp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}