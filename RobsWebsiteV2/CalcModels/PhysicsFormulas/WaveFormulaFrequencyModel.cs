using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class WaveFormulaFrequencyModel
    {
        [Required]
        public double Velocity { get; set; }
        [Required]
        public double Wavelength { get; set; }

        public double Result { get; set; }
    }
}
