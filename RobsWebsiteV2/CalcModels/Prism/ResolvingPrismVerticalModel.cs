using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
