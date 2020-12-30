using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.PhysicsFormulas;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PhysicsFormulasController : Controller
    {
        [HttpGet("WaveFormulaVelocity/{Frequency}/{Wavelength}")]
        public ActionResult<WaveFormulaVelocityModel> WaveFormulaVelocity(WaveFormulaVelocityModel velocity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            velocity.Result = PhysicsFormulas.WaveFormulaVelocity(velocity.Frequency, velocity.Wavelength);
            return velocity;
        }

        [HttpGet("WaveFormulaFrequency/{Velocity}/{Wavelength}")]
        public ActionResult<WaveFormulaFrequencyModel> WaveFormulaFrequency(WaveFormulaFrequencyModel wave)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            wave.Result = PhysicsFormulas.WaveFormulaFrequency(wave.Velocity, wave.Wavelength);
            return wave;
        }

        [HttpGet("WaveFormulaWavelength/{Velocity}/{Frequency}")]
        public ActionResult<WaveFormulaWavelengthModel> WaveFormulaWavelength(WaveFormulaWavelengthModel length)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            length.Result = PhysicsFormulas.WaveFormulaWavelength(length.Velocity, length.Frequency);
            return length;
        }

        [HttpGet("Illumination/{Distance}")]
        public ActionResult<IlluminationModel> Illumination(IlluminationModel illumination)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            illumination.Result = PhysicsFormulas.Illumination(illumination.Distance);
            return illumination;
        }

        [HttpGet("IndexOfRefraction/{SpeedOfLightInMaterial}")]
        public ActionResult<IndexOfRefractionModel> IndexOfRefraction(IndexOfRefractionModel index)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            index.Result = PhysicsFormulas.IndexOfRefraction(index.SpeedOfLightInMaterial);
            return index;
        }

        [HttpGet("SpeedOfLightInMaterial/{IndexOfRefraction}")]
        public ActionResult<SpeedOfLightInMaterialModel> IndexOfRefraction(SpeedOfLightInMaterialModel speedOfLight)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            speedOfLight.Result = PhysicsFormulas.SpeedOfLightInMaterial(speedOfLight.IndexOfRefraction);
            return speedOfLight;
        }









    }
}
