﻿using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrismDiopterApproxModel
    {
        [Required]
        public double ApicalAngle { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
