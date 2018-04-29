using Abp.AutoMapper;
using DJGO.ABPGMEdu.Sessions.Dto;

namespace DJGO.ABPGMEdu.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}