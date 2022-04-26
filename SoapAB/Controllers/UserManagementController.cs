using Microsoft.AspNetCore.Mvc;

namespace SoapAB.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
