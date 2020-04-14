using Abp.Application.Services;
using ABPCoreLearning.MultiTenancy.Dto;

namespace ABPCoreLearning.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

