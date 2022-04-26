using Microsoft.AspNetCore.Mvc;

namespace SoapAB.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
