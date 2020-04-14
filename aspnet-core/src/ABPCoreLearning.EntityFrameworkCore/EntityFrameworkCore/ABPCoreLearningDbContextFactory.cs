using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPCoreLearning.Configuration;
using ABPCoreLearning.Web;

namespace ABPCoreLearning.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPCoreLearningDbContextFactory : IDesignTimeDbContextFactory<ABPCoreLearningDbContext>
    {
        public ABPCoreLearningDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPCoreLearningDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPCoreLearningDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPCoreLearningConsts.ConnectionStringName));

            return new ABPCoreLearningDbContext(builder.Options);
        }
    }
}
