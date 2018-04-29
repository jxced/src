using System.Collections.Generic;
using DJGO.ABPGMEdu.Roles.Dto;
using DJGO.ABPGMEdu.Users.Dto;

namespace DJGO.ABPGMEdu.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}