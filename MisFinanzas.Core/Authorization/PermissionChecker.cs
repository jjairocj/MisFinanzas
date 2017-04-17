using Abp.Authorization;
using MisFinanzas.Authorization.Roles;
using MisFinanzas.MultiTenancy;
using MisFinanzas.Users;

namespace MisFinanzas.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
