using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class FrontVertexPowerModel
    {
            [Required]
            [Range(-30, 30)]
            public double FrontSurfacePower { get; set; }

            [Required]
            [Range(-30, 30)]
            public double BackSurfacePower { get; set; }

            [Required]
            [Range(1, 10)]
            public double Thickness { get; set; }

            [Required]
            [Range(1.498, 1.74)]
            public double Index { get; set; }

            [DisplayFormat(DataFormatString = "{0:0.000}")]
            public double Result { get; set; }
    }
}
