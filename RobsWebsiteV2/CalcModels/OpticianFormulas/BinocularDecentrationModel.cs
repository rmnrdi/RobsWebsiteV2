﻿using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.OpticianFormulas
{
    public class BinocularDecentrationModel
    {
        [Required]
        [Range(10, 80)]
        public double AMeasurement { get; set; }

        [Required]
        [Range(7, 18)]
        public double DBLMeasurement { get; set; }

        [Required]
        [Range(10, 40)]
        public double BinocularPD{ get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }

}
