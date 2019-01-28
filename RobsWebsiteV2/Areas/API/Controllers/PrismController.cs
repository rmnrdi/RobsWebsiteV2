using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.CalcModels.Prism;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PrismController : Controller
    {
        [HttpGet("PrismDeviation/{ApicalAngle}/{Index}")]
        public ActionResult<PrismDeviationModel> PrismDeviation(PrismDeviationModel prism)
        {
            prism.Result = Prism.PrimsDeviation(prism.ApicalAngle, prism.Index);

            return prism;
        }

        /// <summary>
        /// Apical Angle API
        /// </summary>
        /// <param name="prism"></param>
        /// <returns></returns>
        [HttpGet("ApicalAngle/{Deviation}/{Index}")]
        public ActionResult<ApicalAngleModel> ApicalAngle(ApicalAngleModel prism)
        {
            prism.Result = Prism.ApicalAngle(prism.Deviation, prism.Index);

            return prism;
        }

        [HttpGet("PrismDiopter/{Displacement}/{Distance}")]
        public ActionResult<PrismDiopterModel> PrismDiopter(PrismDiopterModel prism)
        {
            prism.Result = Prism.PrismDiopter(prism.Displacement, prism.Distance);

            return prism;
        }

            //public ActionResult<PrismDisplacementModel> PrismDisplacement(PrismDisplacementModel prism)
            //{
            //    prism.Result = Prism.PrismDisplacement(prism.PrismDiopters, prism.Distance);

            //    return prism;
            //}

            //[HttpGet("PrismCentrad/{DeviationAngle}")]
            //public ActionResult<double> PrismCentrad(PrismModel prism)
            //{
            //    if (!ModelState.IsValid)
            //        return BadRequest(ModelState);

            //    prism.Result = Prism.PrismCentrad(prism.DeviationAngle);

            //    return prism.Result;
            //}

            //[HttpGet("PrenticesRuleCentimeters/{LensPower}/{Decentration}")]
            //public ActionResult<PrenticesRuleModel> PrenticesRuleCentimeters(PrenticesRuleModel prism)
            //{
            //    if (!ModelState.IsValid)
            //        return BadRequest(ModelState);

            //    prism.Result = Prism.PrenticesLawCentimeters(prism.LensPower, prism.Decentration);

            //    return prism;
            //}

            //[HttpGet("PrenticesRuleMillimeters/{LensPower}/{Decentration}")]
            //public ActionResult<PrenticesRuleModel> PrenticesRuleMillimeters(PrenticesRuleModel prism)
            //{
            //    if (!ModelState.IsValid)
            //        return BadRequest(ModelState);

            //    prism.Result = Prism.PrenticesLawMillimeters(prism.LensPower, prism.Decentration);

            //    return prism;
            //}
        }
}