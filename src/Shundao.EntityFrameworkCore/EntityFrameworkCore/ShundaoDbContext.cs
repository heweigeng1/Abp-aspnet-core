using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shundao.Authorization.Roles;
using Shundao.Authorization.Users;
using Shundao.MultiTenancy;

namespace Shundao.EntityFrameworkCore
{
    public class ShundaoDbContext : AbpZeroDbContext<Tenant, Role, User, ShundaoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShundaoDbContext(DbContextOptions<ShundaoDbContext> options)
            : base(options)
        {
        }
    }
}
