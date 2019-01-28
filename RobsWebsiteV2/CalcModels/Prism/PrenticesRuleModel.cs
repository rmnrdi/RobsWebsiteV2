using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrenticesRuleModel
    {
        [Required]
        [Range(0,15)]
        public double LensPower { get; set; }
        [Required]
        public double Decentration { get; set; }

       // [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }

    }
}
