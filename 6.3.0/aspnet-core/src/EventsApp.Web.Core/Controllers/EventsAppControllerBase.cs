using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EventsApp.Controllers
{
    public abstract class EventsAppControllerBase: AbpController
    {
        protected EventsAppControllerBase()
        {
            LocalizationSourceName = EventsAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
