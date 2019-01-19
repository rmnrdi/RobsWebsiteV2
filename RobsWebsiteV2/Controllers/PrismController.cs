using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.Models;

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



        [HttpGet("PrismDeviation/{ApicalAngle}/{Index}")]
        public ActionResult<double> PrismDeviation(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrimsDeviation(prism.ApicalAngle, prism.Index);

            return prism.Result;
        }

        [HttpGet("PrismCentrad/{DeviationAngle}")]
        public ActionResult<double> PrismCentrad(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrismCentrad(prism.DeviationAngle);

            return prism.Result;
        }

        [HttpGet("PrenticesLawCentimeters/{LensPower}/{Decentration}")]
        public ActionResult<double> PrenticesLawCentimeters(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrenticesLawCentimeters(prism.LensPower, prism.Decentration);

            return prism.Result;
        }

        [HttpGet("PrenticesLawMillimeters/{LensPower}/{Decentration}")]
        public ActionResult<double> PrenticesLawMillimeters(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrenticesLawMillimeters(prism.LensPower, prism.Decentration);

            return prism.Result;
        }


    }
}