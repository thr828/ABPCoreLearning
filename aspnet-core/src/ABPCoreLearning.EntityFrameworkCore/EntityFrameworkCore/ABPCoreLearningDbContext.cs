using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPCoreLearning.Authorization.Roles;
using ABPCoreLearning.Authorization.Users;
using ABPCoreLearning.MultiTenancy;
using ABPCoreLearning.PhoneBooks.Persons;
using ABPCoreLearning.PhoneBooks.PhoneNumbers;

namespace ABPCoreLearning.EntityFrameworkCore
{
    public class ABPCoreLearningDbContext : AbpZeroDbContext<Tenant, Role, User, ABPCoreLearningDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPCoreLearningDbContext(DbContextOptions<ABPCoreLearningDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person","PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
