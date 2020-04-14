using Abp.AutoMapper;
using ABPCoreLearning.Sessions.Dto;

namespace ABPCoreLearning.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
