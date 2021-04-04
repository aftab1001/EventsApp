using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.EntityFrameworkCore
{
    public static class EventsAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EventsAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EventsAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
