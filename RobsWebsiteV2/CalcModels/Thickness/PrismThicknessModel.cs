using System.ComponentModel.DataAnnotations;



namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class PrismThicknessModel
    {
        [Required]
        public double PrismPower { get; set; }

        [Required]
        public double LensDiameter { get; set; }

        [Required]
        [Range(1.498, 1.74)]
        public double Index { get; set; }

        public double Result { get; set; }
    }
}
