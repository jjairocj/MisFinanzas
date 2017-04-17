using System.Web.Mvc;

namespace MisFinanzas.Web.Controllers
{
    public class AboutController : MisFinanzasControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}