using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.BaseCurve
{
    public class VogelsRulePlusModel
    {
        [Required]
        [Range(0,30)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30,0)]
        public double CylinderPower { get; set; }

        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
