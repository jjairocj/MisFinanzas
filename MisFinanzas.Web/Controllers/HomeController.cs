using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MisFinanzas.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MisFinanzasControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}