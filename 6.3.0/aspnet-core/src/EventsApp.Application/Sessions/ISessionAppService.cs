using System.Threading.Tasks;
using Abp.Application.Services;
using EventsApp.Sessions.Dto;

namespace EventsApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
