using Abp.Authorization;
using EventsApp.Authorization.Roles;
using EventsApp.Authorization.Users;

namespace EventsApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
