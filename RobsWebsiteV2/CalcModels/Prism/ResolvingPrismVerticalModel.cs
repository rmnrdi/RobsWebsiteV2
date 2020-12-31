using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class ResolvingPrismHorizontalModel
    {
        [Required]
        public double PrismPower { get; set; }

        [Required]
        public double Angle { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
