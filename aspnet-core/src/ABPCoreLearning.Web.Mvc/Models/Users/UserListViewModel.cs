using System.Collections.Generic;
using ABPCoreLearning.Roles.Dto;

namespace ABPCoreLearning.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
