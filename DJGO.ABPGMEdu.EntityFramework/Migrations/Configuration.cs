using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using DJGO.ABPGMEdu.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace DJGO.ABPGMEdu.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ABPGMEdu.EntityFramework.ABPGMEduDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPGMEdu";
        }

        protected override void Seed(ABPGMEdu.EntityFramework.ABPGMEduDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
