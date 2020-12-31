using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrismDistanceModel
    {
        [Required]
        public double PrismDiopters { get; set; }

        [Required]
        public double Displacement { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
