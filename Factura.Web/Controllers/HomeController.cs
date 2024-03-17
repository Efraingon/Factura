using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FacturaApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FacturaAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}