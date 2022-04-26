using javax.jws;
using Microsoft.AspNetCore.Mvc;
using SoapAB.Data;
using System.Linq;


namespace SoapAB.Controllers
{
    public class StockManagementController : Controller
    {
        private readonly SoapDBContext _context;
        public StockManagementController(SoapDBContext context)
        {
            _context = context;
        }
        [WebMethod]
        public JsonResult GetText()
        {
            var _articles = _context.Article.Where(p => p.IsInStock == true);
            return Json(_articles.ToList(), System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }
        public IActionResult Index()
        {
            var _articles = _context.Article.Where(p => p.IsInStock == true);

            return View(_articles);
        }
        [HttpGet]
        public IActionResult AddNewStockItem()
        {
            return View();
        }
    }
}
