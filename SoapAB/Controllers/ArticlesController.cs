using Microsoft.AspNetCore.Mvc;

namespace SoapAB.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
