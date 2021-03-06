﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pet.Models;

namespace pet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "We are tring to make more animals' life better.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Here are some ways to contact and help us.";

            return View();
        }

		public IActionResult Login()
		{
            return View();
        }

		public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
