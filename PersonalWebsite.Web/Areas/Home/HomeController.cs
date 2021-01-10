﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonalWebsite.Web.Areas.Home
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(Views.Home.HomeView);
        }
    }
}
