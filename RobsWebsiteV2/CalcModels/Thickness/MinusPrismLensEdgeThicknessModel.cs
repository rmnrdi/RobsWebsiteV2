using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class MinusPrismLensEdgeThicknessModel
    {
        [Required]
        public double SagittalDepth { get; set; }

        [Required]
        public double MinimumCenterThickness { get; set; }

        [Required]
        public double PrismBaseThickness { get; set; }

        public double Result { get; set; }

    }
}
