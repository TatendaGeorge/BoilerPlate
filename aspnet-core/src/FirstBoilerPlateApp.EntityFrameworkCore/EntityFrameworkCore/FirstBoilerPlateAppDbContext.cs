using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FirstBoilerPlateApp.Authorization.Roles;
using FirstBoilerPlateApp.Authorization.Users;
using FirstBoilerPlateApp.MultiTenancy;

namespace FirstBoilerPlateApp.EntityFrameworkCore
{
    public class FirstBoilerPlateAppDbContext : AbpZeroDbContext<Tenant, Role, User, FirstBoilerPlateAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FirstBoilerPlateAppDbContext(DbContextOptions<FirstBoilerPlateAppDbContext> options)
            : base(options)
        {
        }
    }
}
