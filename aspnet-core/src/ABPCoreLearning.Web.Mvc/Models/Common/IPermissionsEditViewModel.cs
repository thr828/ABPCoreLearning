using System.Collections.Generic;
using ABPCoreLearning.Roles.Dto;

namespace ABPCoreLearning.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}