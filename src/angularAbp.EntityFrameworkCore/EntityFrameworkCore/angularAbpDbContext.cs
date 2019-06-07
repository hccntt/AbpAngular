using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using angularAbp.Authorization.Roles;
using angularAbp.Authorization.Users;
using angularAbp.MultiTenancy;

namespace angularAbp.EntityFrameworkCore
{
    public class angularAbpDbContext : AbpZeroDbContext<Tenant, Role, User, angularAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ManagementEmployee.Employee> Employees { get; set; }
        
        public angularAbpDbContext(DbContextOptions<angularAbpDbContext> options)
            : base(options)
        {
        }
    }
}
