using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class PlusPrismLensCenterThicknessModel
    {
        [Required]
        public double SagittalDepth { get; set; }

        [Required]
        public double MinimumEdgeThickness { get; set; }

        [Required]
        public double PrismBaseThickness { get; set; }

        public double Result { get; set; }
    }
}
