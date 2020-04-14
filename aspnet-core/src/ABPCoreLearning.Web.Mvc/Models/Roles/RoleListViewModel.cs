using System.Collections.Generic;
using ABPCoreLearning.Roles.Dto;

namespace ABPCoreLearning.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
