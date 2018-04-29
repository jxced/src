using DJGO.ABPGMEdu.EntityFramework;
using EntityFramework.DynamicFilters;

namespace DJGO.ABPGMEdu.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPGMEduDbContext _context;

        public InitialHostDbBuilder(ABPGMEduDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
