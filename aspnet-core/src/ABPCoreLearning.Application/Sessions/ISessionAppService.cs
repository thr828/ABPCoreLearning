using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreLearning.Sessions.Dto;

namespace ABPCoreLearning.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
