using Abp.MultiTenancy;
using DJGO.ABPGMEdu.Authorization.Users;

namespace DJGO.ABPGMEdu.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}