using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Models
{
    public class PrismModel
    {
        //ApicalAngle
        [Range(0,90)]
        public double DegreesDeviation { get; set; }
        public double Index { get; set; }
        public double ApicalAngle { get; set; }
        public double DeviationAngle { get; set; }

        //Effective Decentration
        public double HorizontalDecentration { get; set; }
        public double VerticalDecentration { get; set; }
        public double CylinderAxis { get; set; }

        //PrenticesLaw
        [Required]
        [Range(0, 30)]
        public double LensPower { get; set; }
        [Required]
        [Range(0, 30)]
        public double Decentration { get; set; }

        public double Result { get; set; }
    }
}
