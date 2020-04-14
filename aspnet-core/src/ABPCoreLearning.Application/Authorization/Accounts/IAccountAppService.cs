using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreLearning.Authorization.Accounts.Dto;

namespace ABPCoreLearning.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
