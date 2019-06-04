using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using angularAbp.Configuration;
using angularAbp.Web;

namespace angularAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class angularAbpDbContextFactory : IDesignTimeDbContextFactory<angularAbpDbContext>
    {
        public angularAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<angularAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            angularAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(angularAbpConsts.ConnectionStringName));

            return new angularAbpDbContext(builder.Options);
        }
    }
}
