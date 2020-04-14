using Abp.Authorization;
using ABPCoreLearning.Authorization.Roles;
using ABPCoreLearning.Authorization.Users;

namespace ABPCoreLearning.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
