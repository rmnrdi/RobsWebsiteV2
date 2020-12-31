using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrenticesRuleCMModel
    {
        [Required]
        public double LensPower { get; set; }

        [Required]
        public double Decentration { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
