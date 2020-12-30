using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.BaseCurve
{
    public class BoddyFormula
    {
        [Required]
        [Range(-30, 30)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30, 0)]
        public double CylinderPower { get; set; }
        
        [Required]
        [Range(0, 5)]
        public double AddPower { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
