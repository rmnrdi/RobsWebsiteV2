using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.Magnification;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.api.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class MagnificationController : Controller
    {
        [HttpGet("SpectacleMagnification/{FrontBaseCurve}/{ActualLensPower}/{Index}/{Thickness}/{VertexDistance}")]        
        public ActionResult<SpectacleMagnificationModel> SpectacleMagnification(SpectacleMagnificationModel magnification)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            magnification.Result = Magnification.SpectacleMagnification(magnification.FrontBaseCurve, magnification.ActualLensPower, magnification.Index, magnification.Thickness, magnification.VertexDistance);
            return magnification;
        }
    }
}
