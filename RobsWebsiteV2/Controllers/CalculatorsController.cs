using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Controllers
{
    public class CalculatorsController : Controller
    {
        public IActionResult CalculatorsHome ()
        {
            return View();
        }
    }
}
