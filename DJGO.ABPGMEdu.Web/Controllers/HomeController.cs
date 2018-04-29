using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace DJGO.ABPGMEdu.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPGMEduControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}