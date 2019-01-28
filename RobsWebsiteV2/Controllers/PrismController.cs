using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Controllers
{
    [Route("[Controller]")]
    public class PrismController : Controller
    {
        /// <summary>
        /// Apical Angle Calculation View Get
        /// </summary>
        /// <returns></returns>
        [HttpGet("ApicalAngleCalc")]
        public IActionResult ApicalAngleCalc()
        {
            return View();
        }

        /// <summary>
        /// Apical Angle Calculation View Post
        /// </summary>
        /// <param name="prism"></param>
        /// <returns></returns>
        [HttpPost("ApicalAngleCalc")]
        public ActionResult<ApicalAngleModel> ApicalAngleCalc(ApicalAngleModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dev = prism.Deviation;

            prism.Result = Prism.ApicalAngle(prism.Deviation, prism.Index);

            return View(prism);
        }
    }
}