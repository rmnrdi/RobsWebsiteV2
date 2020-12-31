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

        [HttpGet("SurfacePower/{Index}/{RadiusOfCurvature}")]
        public ActionResult<SurfacePowerModel> SurfacePower(SurfacePowerModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Power.SurfacePower(power.Index, power.RadiusOfCurvature);
            return power;
        }

        [HttpGet("RadiusOfCurvature/{Index}/{DioptricPower}")]
        public ActionResult<RadiusOfCurvatureModel> RadiusOfCurvature(RadiusOfCurvatureModel radius)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            radius.Result = Power.RadiusOfCurvature(radius.Index, radius.DioptricPower);
            return radius;
        }

        [HttpGet("NominalPower/{DioptricPowerFront}/{DioptricPowerBack}")]
        public ActionResult<NominalPowerModel> NominalPower(NominalPowerModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Power.NominalPower(power.DioptricPowerFront, power.DioptricPowerBack);
            return power;
        }
        [HttpGet("NominalBacksidePower/{DioptricPowerFront}/{TotalLensPower}")]
        public ActionResult<NominalBackSidePowerModel> NominalBacksidePower(NominalBackSidePowerModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Power.NominalBacksidePower(power.DioptricPowerFront, power.TotalLensPower);
            return power;

        }

        [HttpGet("LensMakersEquation/{Index}/{RadiusOfCurvatureFront}/{RadiusOfCurvatureBack}")]
        public ActionResult<LensMakerEquationModel> LensMakerEquation(LensMakerEquationModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Power.LensMakersEquation(power.Index, power.RadiusOfCurvatureFront, power.RadiusOfCurvatureBack);
            return power;
        }

        [HttpGet("SpericalEquivelant/{SpherePower}/{CylinderPower}")]
        public ActionResult<SphericalEquivelantModel> SphericalEquivelant(SphericalEquivelantModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Power.SpericalEquivalant(power.SpherePower, power.CylinderPower);
            return power;
        }






    }
}
