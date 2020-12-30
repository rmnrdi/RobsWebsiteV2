using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class WaveFormulaVelocityModel
    {
        [Required]
        public double Frequency { get; set; }
        [Required]
        public double Wavelength { get; set; }

        public double Result { get; set; }
    }
}
