using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using DJGO.ABPGMEdu.EntityFramework;

namespace DJGO.ABPGMEdu
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPGMEduCoreModule))]
    public class ABPGMEduDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPGMEduDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
