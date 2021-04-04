using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EventsApp.Authorization;

namespace EventsApp
{
    [DependsOn(
        typeof(EventsAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EventsAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EventsAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EventsAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
