using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class ResultantPrismAngleRightEyeModel
    {
        [Required]
        public double VerticalComponent { get; set; }

        [Required]
        public double HorizontalComponent { get; set; }


        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}