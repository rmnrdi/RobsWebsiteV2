using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Tilt
{
    public class MartinTiltFormulaInducedCylinderModel
    {
        [Required]
        [Range(-30, 30)]
        public double NewSpherePower { get; set; }

        [Required]
        [Range(0, 360)]
        public double DegreesOfTilt { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
