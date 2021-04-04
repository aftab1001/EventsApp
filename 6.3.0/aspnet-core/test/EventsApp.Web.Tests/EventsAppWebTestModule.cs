using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EventsApp.EntityFrameworkCore;
using EventsApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EventsApp.Web.Tests
{
    [DependsOn(
        typeof(EventsAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EventsAppWebTestModule : AbpModule
    {
        public EventsAppWebTestModule(EventsAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EventsAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EventsAppWebMvcModule).Assembly);
        }
    }
}