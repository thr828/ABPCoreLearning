using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPCoreLearning.EntityFrameworkCore
{
    public static class ABPCoreLearningDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPCoreLearningDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPCoreLearningDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
