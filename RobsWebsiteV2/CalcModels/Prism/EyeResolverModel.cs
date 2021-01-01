﻿using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Prism
{
    public class EyeResolverModel
    {
        [Required]
        public double  PrismBaseAngle { get; set; }

        [Required]
        public string VerticalBaseDirection { get; set; }

        [Required]
        public string HorizontalBaseDirection { get; set; }

        public string Result { get; set; }
    }
}