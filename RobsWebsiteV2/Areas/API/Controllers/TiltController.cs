using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.Tilt;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class TiltController : Controller
    {
        [HttpGet("MartinTiltFormulaSphere/{OriginalSpherePower}/{DegreesOfTilt}/{Index}")]
        public ActionResult<MartinTiltFormulaSphereModel> MartinTiltFormulaSphere(MartinTiltFormulaSphereModel sphere)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            sphere.Result = Tilt.MartinTiltFormulaSphere(sphere.OriginalSpherePower, sphere.DegreesOfTilt, sphere.Index);
            return sphere;
        }

        [HttpGet("MartinTiltFormulaInducedCylinder/{NewSpherePower}/{DegreesOfTilt}")]
        public ActionResult<MartinTiltFormulaInducedCylinderModel> MartinTiltFormulaInducedCylinder(MartinTiltFormulaInducedCylinderModel cylinder)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            cylinder.Result = Tilt.MartinTiltFormulaInducedCylinder(cylinder.NewSpherePower, cylinder.DegreesOfTilt);
            return cylinder;
        }
    }
}
