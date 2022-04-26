using Microsoft.AspNetCore.Mvc;

namespace SoapAB.Controllers
{
    public class SalesOverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
