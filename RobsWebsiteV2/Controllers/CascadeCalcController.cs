using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RobsWebsiteV2.Models;

namespace RobsWebsiteV2.Controllers
{
    public class CascadeCalcController : Controller
    {
        public IActionResult CalcTypes()
        {
            ViewBag.Calcs = CalcPage.GetCalcTypes();
            return View();
        }

        public JsonResult GetCalcByName(string calcType)
        {
            
            
            var calcNames = CalcPage.GetCalcNames(calcType);

            


            return Json(new SelectList(calcNames));
        }
    }
}