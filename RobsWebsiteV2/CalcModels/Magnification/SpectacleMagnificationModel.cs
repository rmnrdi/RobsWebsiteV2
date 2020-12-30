using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Magnification
{
    public class SpectacleMagnificationModel
    {
        [Required]
        [Range(0, 30)]
        public double FrontBaseCurve { get; set; }

        [Required]
        [Range(-30, 30)]
        public double ActualLensPower { get; set; }

        [Required]
        [Range(1.498, 1.74)]
        public double Index { get; set; }

        [Required]
        [Range(1, 10)]
        public double Thickness { get; set; }

        [Required]
        [Range(0,16)]
        public double VertexDistance { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
