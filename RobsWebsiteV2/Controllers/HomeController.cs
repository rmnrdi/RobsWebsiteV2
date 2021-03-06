﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RobsWebsiteV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Loading Home Controller...");
        }
        
        public IActionResult Index()
        {
            _logger.LogInformation("Loading Home Page...");
            return View();
        }

        public IActionResult Skills()
        {
            _logger.LogInformation("Loading Skills Page...");
            return View();
        }

        public IActionResult Lectures()
        {
            _logger.LogInformation("Loading Lectures Page...");
            return View();
        }

        public IActionResult Articles()
        {
            _logger.LogInformation("Loading Articles Page...");
            return View();
        }

        public IActionResult Projects()
        {
            _logger.LogInformation("Loading Projects Page...");
            return View();
        }

        public IActionResult Achievements()
        {
            _logger.LogInformation("Loading Achievements Page...");
            return View();
        }

        public IActionResult Video()
        {
            _logger.LogInformation("Loading Video Page...");
            return View();
        }

        public IActionResult Contact()
        {
            _logger.LogInformation("Loading Contact Page...");
            return View();
        }

        public IActionResult Error()
        {
            _logger.LogInformation("Loading Error Page...");
            return View();
        }

        public IActionResult CalculatorsHome()
        {
            _logger.LogInformation("Loading Calculator Page...");
            return View();
        }
    }
}
