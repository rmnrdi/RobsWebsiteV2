using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.CalcModels.Prism;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PrismController : Controller
    {
        /// <summary>
        /// Prism Deviation
        /// </summary>
        /// <param name="prism"></param>
        /// <returns></returns>
        [HttpGet("PrismDeviation/{ApicalAngle}/{Index}")]
        public ActionResult<PrismDeviationModel> PrismDeviation(PrismDeviationModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

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
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ApicalAngle(prism.Deviation, prism.Index);
            return prism;
        }

        [HttpGet("PrismDiopter/{Displacement}/{Distance}")]
        public ActionResult<PrismDiopterModel> PrismDiopter(PrismDiopterModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrismDiopter(prism.Displacement, prism.Distance);
            return prism;
        }

        [HttpGet("PrismDisplacement/{PrismDiopter}/{Distance}")]
        public ActionResult<PrismDisplacementModel> PrismDisplacement(PrismDisplacementModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrismDisplacement(prism.PrismDiopters, prism.Distance);
            return prism;
        }

        [HttpGet("PrismDistance/{PrismDiopters}/{Displacement}")]
        public ActionResult<PrismDistanceModel> PrismDistance(PrismDistanceModel distance)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            distance.Result = Prism.PrismDistance(distance.PrismDiopters, distance.Displacement);
            return distance;
        }

        [HttpGet("PrismCentrad/{DeviationAngle}")]
        public ActionResult<PrismCentradModel> PrismCentrad(PrismCentradModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrismCentrad(prism.DeviationAngle);
            return prism;
        }

        [HttpGet("PrismDiopterApprox/{ApicalAngle}/{Index}")]
        public ActionResult<PrismDiopterApproxModel> PrismDiopterApprox(PrismDiopterApproxModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrismDiopterApproximation(prism.ApicalAngle, prism.Index);
            return prism;
        }

        [HttpGet("PrenticesRuleCentimeters/{LensPower}/{Decentration}")]
        public ActionResult<PrenticesRuleCMModel> PrenticesRuleCentimeters(PrenticesRuleCMModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrenticesLawCentimeters(prism.LensPower, prism.Decentration);
            return prism;
        }

        [HttpGet("PrenticesRuleMillimeters/{LensPower}/{Decentration}")]
        public ActionResult<PrenticesRuleModel> PrenticesRuleMillimeters(PrenticesRuleModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.PrenticesLawMillimeters(prism.LensPower, prism.Decentration);
            return prism;
        }

        [HttpGet("ResultantPrism/{VerticalComponent}/{HorizontalComponent}")]
        public ActionResult<ResultantPrismModel> ResultantPrism(ResultantPrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ResultantPrism(prism.VerticalComponent, prism.HorizontalComponent);
            return prism;
        }

        [HttpGet("EffectiveDecentration/{HorizontalDecentration}/{VerticalDecentration,CylinderAxis}")]
        public ActionResult<EffectiveDecentrationModel> EffectiveDecentration(EffectiveDecentrationModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.EffectiveDecentration(prism.HorizontalDecentration, prism.VerticalDecentration, prism.CylinderAxis);
            return prism;
        }

        [HttpGet("ResultantPrismAngleRightEye/{VerticalComponent}/{HorizontalDecentration}")]
        public ActionResult<ResultantPrismAngleRightEyeModel> ResultantPrismAngleRightEye(ResultantPrismAngleRightEyeModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ResultantPrismAngleRightEye(prism.VerticalComponent, prism.HorizontalComponent);
            return prism;
        }

        [HttpGet("ResultantPrismAngleLeftEye/{VerticalComponent}/{HorizontalDecentration}")]
        public ActionResult<ResultantPrismAngleLeftEyeModel> ResultantPrismAngleLeftEye(ResultantPrismAngleLeftEyeModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ResultantPrismAngleRightEye(prism.VerticalComponent, prism.HorizontalComponent);
            return prism;
        }

        [HttpGet("ResolvingPrismHorizontal/{PrismPower}/{Angle}")]
        public ActionResult<ResolvingPrismHorizontalModel> ResolvingPrismHorizontal(ResolvingPrismHorizontalModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ResultantPrismAngleRightEye(prism.PrismPower, prism.Angle);
            return prism;
        }

        [HttpGet("ResolvingPrismVertical/{PrismPower}/{Angle}")]
        public ActionResult<ResolvingPrismVerticalModel> ResolvingPrismVertical(ResolvingPrismVerticalModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ResultantPrismAngleRightEye(prism.PrismPower, prism.Angle);
            return prism;
        }

        [HttpGet("EyeResolver/{PrismBaseAngle}/{VerticalBaseDirection}/{HorizontalBaseDirection}")]
        public ActionResult<EyeResolverModel> EyeResolver(EyeResolverModel eye)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            eye.Result = Prism.EyeResolver(eye.PrismBaseAngle, eye.VerticalBaseDirection, eye.HorizontalBaseDirection);
            return eye;

        }
    }
}