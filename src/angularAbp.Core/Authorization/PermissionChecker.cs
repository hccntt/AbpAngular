using Abp.Authorization;
using angularAbp.Authorization.Roles;
using angularAbp.Authorization.Users;

namespace angularAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
