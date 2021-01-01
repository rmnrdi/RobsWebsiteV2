using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Tilt
{
    public class MartinTiltFormulaSphereModel
    {
        [Required]
        [Range(-30,30)]
        public double OriginalSpherePower { get; set; }

        [Required]
        [Range(0,30)]
        public double DegreesOfTilt { get; set; }

        [Required]
        [Range(1.498, 1.74)]
        public double Index { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
