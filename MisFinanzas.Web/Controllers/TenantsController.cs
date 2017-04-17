using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MisFinanzas.Authorization;
using MisFinanzas.MultiTenancy;

namespace MisFinanzas.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MisFinanzasControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}