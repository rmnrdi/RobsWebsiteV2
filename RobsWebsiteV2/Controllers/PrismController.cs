using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.Models;
using RobsWebsiteV2.CalcModels;

namespace RobsWebsiteV2.Controllers
{
    [Route("[controller]")]
    public class PrismController : Controller
    {
        /// <summary>
        /// Apical Angle Calculation View Get
        /// </summary>
        /// <returns></returns>
        [HttpGet("ApicalAngle")]
        public IActionResult ApicalAngleCalc()
        {
            return View();
        }

        /// <summary>
        /// Apical Angle Calculation View Post
        /// </summary>
        /// <param name="prism"></param>
        /// <returns></returns>
        [HttpPost("ApicalAngle")]
        public ActionResult<PrismModel> ApicalAngleCalc(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dev = prism.DegreesDeviation;

            prism.Result = Prism.ApicalAngle(prism.DegreesDeviation, prism.Index);

            return View(prism);
        }
    }
}