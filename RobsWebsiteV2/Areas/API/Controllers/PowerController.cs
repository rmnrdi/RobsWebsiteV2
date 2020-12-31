using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.Power;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PowerController : Controller
    {
        [HttpGet("Vergence/{Distance}")]
        public ActionResult<VergenceModel> Vergence(VergenceModel vergence)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            vergence.Result = Power.Vergence(vergence.Distance);
            return vergence;
        }

    }
}
