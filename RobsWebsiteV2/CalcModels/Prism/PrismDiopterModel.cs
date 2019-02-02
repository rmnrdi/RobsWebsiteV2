using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrismDiopterModel
    {
        [Required]
        public double Displacement { get; set; }

        [Required]
        public double Distance { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}