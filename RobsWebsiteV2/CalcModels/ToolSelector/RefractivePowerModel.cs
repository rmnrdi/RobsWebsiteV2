using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.ToolSelector
{
    public class RefractivePowerModel
    {
        [Required]
        [Range(-30, 30)]
        public double ToolPower { get; set; }

        [Required]
        [Range(1.498, 1.74)]
        public double  Index { get; set; }

        [DisplayFormat(DataFormatString = "0:0.000")]
        public double Result { get; set; }
    }
}
