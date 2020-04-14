using Abp.Application.Services.Dto;

namespace ABPCoreLearning.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

