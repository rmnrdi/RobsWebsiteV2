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

        [HttpGet("DioptricPower/{Distance}")]
        public ActionResult<DioptricPowerModel> DioptricPower(DioptricPowerModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            power.Result = Power.DioptricPower(power.Distance);
            return power;
        }

        [HttpGet("FocalDistance/{Diopter}")]
        public ActionResult<FocalDistanceModel> FocalDistance(FocalDistanceModel distance)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            distance.Result = Power.FocalDistance(distance.DioptricPower);
            return distance;
        }

    }
}
