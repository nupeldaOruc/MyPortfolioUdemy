﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.ViewComponents.LayoutViewComponents;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}