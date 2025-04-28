using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.ViewComponents;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}