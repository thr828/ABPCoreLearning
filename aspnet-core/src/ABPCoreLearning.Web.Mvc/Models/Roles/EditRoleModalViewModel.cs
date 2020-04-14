using Abp.AutoMapper;
using ABPCoreLearning.Roles.Dto;
using ABPCoreLearning.Web.Models.Common;

namespace ABPCoreLearning.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
