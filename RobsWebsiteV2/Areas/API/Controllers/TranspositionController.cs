using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.CalcModels;
using RobsWebsiteV2.CalcModels.Transposition;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class TranspositionController : Controller
    {
        [HttpGet("TransposeSpherePower/{SpherePower}/{CylinderPower}")]
        public ActionResult<TransposeSpherePowerModel> Transpose(TransposeSpherePowerModel sphere)
        {
            sphere.Result = Transposition.TransposeSpherePower(sphere.SpherePower, sphere.CylinderPower);
            return sphere;
        }

        [HttpGet("TransposeCylinderSign/{CylinderPower}")]
        public ActionResult<TransposeCylinderSignModel> TransposeCylinderSign(TransposeCylinderSignModel cylinder)
        {
            cylinder.Result = Transposition.TransposedCylinderSign(cylinder.CylinderPower);
            return cylinder;
        }

        [HttpGet("TransposeAxis/{CylinderPower}/{CylinderAxis}")]
        public ActionResult<TransposeAxisModel> TransposeAxis(TransposeAxisModel axis)
        {
            axis.Result = Transposition.TransposeAxis(axis.CylinderPower, axis.CylinderAxis);
            return axis;
        }
    }
}
