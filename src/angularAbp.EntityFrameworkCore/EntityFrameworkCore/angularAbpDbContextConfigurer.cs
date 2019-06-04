using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace angularAbp.EntityFrameworkCore
{
    public static class angularAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<angularAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<angularAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
