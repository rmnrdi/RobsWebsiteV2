using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.CalcModels.BaseCurve;

namespace RobsWebsiteV2.Areas.api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class BaseCurveController : Controller
    {
        [HttpGet("VogelsRulePlus/{SpherePower}/{CylinderPower}")]
        public ActionResult<VogelsRulePlusModel> VogelsRulePlus(VogelsRulePlusModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRulePlus(baseCurve.SpherePower, baseCurve.CylinderPower);
            return baseCurve;
        }

        [HttpGet("VogelsRuleMinus/{SpherePower}/{CylinderPower}")]
        public ActionResult<VogelsRuleMinusModel> VogelsRuleMinus(VogelsRuleMinusModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRuleMinus(baseCurve.SpherePower, baseCurve.CylinderPower);
            return baseCurve;
        }

        [HttpGet("BoddyFormulaPlus/{SpherePower}/{CylinderPower}/{AddPower}")]
        public ActionResult<BoddyFormulaPlus> BoddyFormulaPlus(BoddyFormulaPlus baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.BoddyFormulaPlus(baseCurve.SpherePower, baseCurve.CylinderPower, baseCurve.AddPower);
            return baseCurve;
        }

        [HttpGet("BoddyFormulaMinus/{SpherePower}/{CylinderPower}/{AddPower}")]
        public ActionResult<BoddyFormulaMinus> BoddyFormulaMinus(BoddyFormulaMinus baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.BoddyFormulaMinus(baseCurve.SpherePower, baseCurve.CylinderPower, baseCurve.AddPower);
            return baseCurve;
        }

        [HttpGet("BoddyFormula/{SpherePower}/{CylinderPower}/{AddPower}")]
        public ActionResult<BoddyFormula> BoddyFormula(BoddyFormula baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.BoddyFormula(baseCurve.SpherePower, baseCurve.CylinderPower, baseCurve.AddPower);
            return baseCurve;
        }
    }
}
