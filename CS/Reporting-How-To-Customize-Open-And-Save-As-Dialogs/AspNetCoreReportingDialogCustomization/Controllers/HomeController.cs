using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreReportingDialogCustomization.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
