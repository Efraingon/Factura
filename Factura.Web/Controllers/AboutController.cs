using System.Web.Mvc;

namespace FacturaApp.Web.Controllers
{
    public class AboutController : FacturaAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}