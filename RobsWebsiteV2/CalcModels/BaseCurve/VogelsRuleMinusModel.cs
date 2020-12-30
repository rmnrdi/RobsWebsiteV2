using System;
using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.BaseCurve
{
    public class VogelsRuleMinusModel
    {
        [Required]
        [Range(-30, 0)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30, -0)]
        public double CylinderPower { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
