﻿using Microsoft.AspNetCore.Mvc;

namespace Homework_2__Backend_.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult About()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
	}
}
