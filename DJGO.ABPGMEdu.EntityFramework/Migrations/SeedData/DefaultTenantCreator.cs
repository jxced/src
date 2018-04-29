using System.Linq;
using DJGO.ABPGMEdu.EntityFramework;
using DJGO.ABPGMEdu.MultiTenancy;

namespace DJGO.ABPGMEdu.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPGMEduDbContext _context;

        public DefaultTenantCreator(ABPGMEduDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
