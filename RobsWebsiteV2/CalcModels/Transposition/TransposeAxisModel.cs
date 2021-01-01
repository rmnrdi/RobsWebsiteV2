using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Transposition
{
    public class TransposeAxisModel
    {
        [Required]
        [Range(-30, 0)]
        public double CylinderPower { get; set; }

        [Required]
        [Range(1, 180)]
        public double CylinderAxis { get; set; }

        [DisplayFormat(DataFormatString = "0:0.000")]
        public double Result { get; set; }

    }
}
