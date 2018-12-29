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
    [Produces("application/json")]
    [Route("api/Prism")]
    public class PrismController : Controller
    {
        [HttpGet("ApicalAngle/{DegreesDeviation}/{Index}")]
        public ActionResult<PrismModel> ApicalAngle(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ApicalAngle(prism.DegreesDeviation, prism.Index);

            return prism;
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