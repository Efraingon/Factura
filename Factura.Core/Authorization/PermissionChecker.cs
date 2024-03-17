using Abp.Authorization;
using FacturaApp.Authorization.Roles;
using FacturaApp.Authorization.Users;

namespace FacturaApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
