using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class PortfolioController
    {
        public class PortfolioControllers : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}