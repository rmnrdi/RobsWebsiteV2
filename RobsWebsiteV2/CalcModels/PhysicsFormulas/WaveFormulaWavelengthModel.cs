using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class WaveFormulaWavelengthModel
    {
        [Required]
        public double Velocity { get; set; }
        [Required]
        public double Frequency { get; set; }

        public double Result { get; set; }
    }
}
