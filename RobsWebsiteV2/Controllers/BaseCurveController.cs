using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.Models;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Controllers
{
    [Produces("application/json")]
    [Route("api/BaseCurve")]
    public class BaseCurveController : Controller
    {
        [HttpGet("VogelRulePlus/{SpherePower}/{CylinderPower}")]
        public ActionResult<double> VogelRulePlus(BaseCurveModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRulePlus(baseCurve.SpherePower, baseCurve.CylinderPower);

            return baseCurve.Result;
        }

        [HttpGet("VogelRuleMinus/{SpherePower}/{CylinderPower}")]
        public ActionResult<double> VogelRuleMinus(BaseCurveModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRuleMinus(baseCurve.SpherePower, baseCurve.CylinderPower);

            return baseCurve.Result;
        }

    }


   
}