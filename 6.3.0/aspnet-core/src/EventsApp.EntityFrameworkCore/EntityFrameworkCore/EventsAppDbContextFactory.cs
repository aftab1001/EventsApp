using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EventsApp.Configuration;
using EventsApp.Web;

namespace EventsApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EventsAppDbContextFactory : IDesignTimeDbContextFactory<EventsAppDbContext>
    {
        public EventsAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EventsAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EventsAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EventsAppConsts.ConnectionStringName));

            return new EventsAppDbContext(builder.Options);
        }
    }
}
