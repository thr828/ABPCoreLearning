using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPCoreLearning.Authorization.Roles;
using ABPCoreLearning.Authorization.Users;
using ABPCoreLearning.MultiTenancy;

namespace ABPCoreLearning.EntityFrameworkCore
{
    public class ABPCoreLearningDbContext : AbpZeroDbContext<Tenant, Role, User, ABPCoreLearningDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPCoreLearningDbContext(DbContextOptions<ABPCoreLearningDbContext> options)
            : base(options)
        {
        }
    }
}
