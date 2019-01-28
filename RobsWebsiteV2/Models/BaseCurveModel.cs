using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Models
{
    public class BaseCurveModel
    {
        [Required]
        [Range(0, 30)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30, -0)]
        public double CylinderPower { get; set; }
       
        [Range(1, 180)]
        public double? CylAxis { get; set; }

        [Range(0, 5)]
        public double? AddPower { get; set; }

        [Required]
        public double Result { get; set; }

    }
}
