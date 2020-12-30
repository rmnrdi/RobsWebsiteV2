using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.OpticianFormulas
{
    public class MinimumBlankSizeModel
    {
        [Required]
        [Range(10, 70)]
        public double EffectiveDiameter { get; set; }

        [Required]
        [Range(0, 20)]
        public double MonocularDecentration { get; set; }

        [Required]
        public bool ChipFactor { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }

}
