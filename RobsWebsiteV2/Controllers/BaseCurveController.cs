using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.BaseCurve;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Controllers
{
    public class BaseCurveController : Controller
    {
        public IActionResult VogelsRulePlus(VogelsRulePlusModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRulePlus(baseCurve.SpherePower, baseCurve.CylinderPower);
            return View(baseCurve);
        }

        public IActionResult VogelsRuleMinus(VogelsRuleMinusModel baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.VogelsRuleMinus(baseCurve.SpherePower, baseCurve.CylinderPower);
            return View(baseCurve);
        }

        public IActionResult BoddyFormula(BoddyFormula baseCurve)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            baseCurve.Result = BaseCurve.BoddyFormula(baseCurve.SpherePower, baseCurve.CylinderPower, baseCurve.AddPower);
            return View(baseCurve);
        }
    }
}
