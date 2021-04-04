using Abp.Application.Services;
using EventsApp.MultiTenancy.Dto;

namespace EventsApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

