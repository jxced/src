using System.Collections.Generic;
using DJGO.ABPGMEdu.Roles.Dto;

namespace DJGO.ABPGMEdu.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}