using System.Threading.Tasks;
using Abp.Application.Services;
using EventsApp.Authorization.Accounts.Dto;

namespace EventsApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
