using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EventsApp.Authorization.Roles;
using EventsApp.Authorization.Users;
using EventsApp.MultiTenancy;

namespace EventsApp.EntityFrameworkCore
{
    public class EventsAppDbContext : AbpZeroDbContext<Tenant, Role, User, EventsAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EventsAppDbContext(DbContextOptions<EventsAppDbContext> options)
            : base(options)
        {
        }
    }
}
