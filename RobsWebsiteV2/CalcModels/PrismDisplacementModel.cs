using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.CalcModels
{
    public class PrismDisplacementModel
    {
        [Required]
        public double PrismDiopters { get; set; }
        public double Distance { get; set; }

        public double Result { get; set; }
    }
}
