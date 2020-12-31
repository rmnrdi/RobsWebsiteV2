using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class EffectivePowerModel
    {
        [Required]
        [Range(-30,30)]
        public double OriginalPower { get; set; }
        
        [Required]
        [Range(0, 10)]
        public double VertexChange { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
