using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class PowerMeridian90Model
    {
        [Required]
        [Range(-30, 30)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30, 0)]
        public double CylinderPower { get; set; }

        [Required]
        [Range(0, 360)]
        public int DegreesTheta { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}

