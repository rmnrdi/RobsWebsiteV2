using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class LensMakerEquationModel
    {
        [Required]
        [Range(1.498, 1.74)]
        public double Index { get; set; }

        [Required]
        [Range(-30, 30)]
        public double RadiusOfCurvatureFront { get; set; }

        [Required]
        [Range(-30, 30)]
        public double RadiusOfCurvatureBack { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }

    }
}
