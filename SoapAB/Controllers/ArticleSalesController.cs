using Microsoft.AspNetCore.Mvc;

namespace SoapAB.Controllers
{
    public class ArticleSalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
