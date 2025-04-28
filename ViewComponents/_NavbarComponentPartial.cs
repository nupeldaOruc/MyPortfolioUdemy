using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.ViewComponents;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
