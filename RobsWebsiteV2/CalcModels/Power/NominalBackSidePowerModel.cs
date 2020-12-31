using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class NominalBackSidePowerModel
    {
        [Required]
        [Range(-30,30)]
        public double DioptricPowerFront { get; set; }

        [Required]
        [Range(-30, 30)]
        public double TotalLensPower { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
