 using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class DefaultControllercs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
