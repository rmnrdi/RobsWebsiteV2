using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.OpticianFormulas;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class OpticianFormulasController : Controller
    {
        [HttpGet("AstigmatismEvaluator/{SpherePower}/{CylinderPower}")]
        public ActionResult<AstigmatismEvaluatorModel> AstigmatismEvaluator(AstigmatismEvaluatorModel evaluator)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            evaluator.Result = OpticianFormulas.AstigmatismEvaluator(evaluator.SpherePower, evaluator.CylinderPower);
            return evaluator;
        }

        [HttpGet("BinocularDecentration/{AMeasurement}/{DBLMeasurement}/{BinocularPD}")]
        public ActionResult<BinocularDecentrationModel> BinocularDecentration(BinocularDecentrationModel decentration)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            decentration.Result = OpticianFormulas.BinocularDecentration(decentration.AMeasurement,decentration.DBLMeasurement,decentration.BinocularPD);
            return decentration;
        }

        [HttpGet("MonocularDecentration/{AMeasurement}/{DBLMeasurement}/{MonocularPD}")]
        public ActionResult<MonocularDecentrationModel> MonocularDecentration(MonocularDecentrationModel decentration)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            decentration.Result = OpticianFormulas.MonocularDecentration(decentration.AMeasurement, decentration.DBLMeasurement, decentration.MonocularPD);
            return decentration;
        }

        [HttpGet("MinimumBlankSize/{EffectiveDiameter}/{MonocularDecentration}/{ChipFactor}")]
        public ActionResult<MinimumBlankSizeModel> MinimumBlankSize(MinimumBlankSizeModel blank)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            blank.Result = OpticianFormulas.MinimumBlankSize(blank.EffectiveDiameter, blank.MonocularDecentration, blank.ChipFactor);
            return blank;
        }
        
        [HttpGet("SegDrop/{SegHeight}/{BMeasurement}")]
        public ActionResult<SegDropModel> SegDrop(SegDropModel drop)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            drop.Result = OpticianFormulas.SegDrop(drop.SegHeight, drop.BMeasurement);
            return drop;
        }

    }
}
