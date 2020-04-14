using System.Collections.Generic;
using System.Linq;
using ABPCoreLearning.Roles.Dto;
using ABPCoreLearning.Users.Dto;

namespace ABPCoreLearning.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
