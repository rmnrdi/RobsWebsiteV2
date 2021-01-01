using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Transposition
{
    public class TransposeCylinderSignModel
    {
        [Required]
        [Range(-30, 0)]
        public double CylinderPower { get; set; }

        public double Result { get; set; }
    }
}
