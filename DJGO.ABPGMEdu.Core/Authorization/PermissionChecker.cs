using Abp.Authorization;
using DJGO.ABPGMEdu.Authorization.Roles;
using DJGO.ABPGMEdu.Authorization.Users;

namespace DJGO.ABPGMEdu.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
