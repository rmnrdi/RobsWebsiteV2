using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class PlusPrismLensThickestEdgeModel
    {
        [Required]
        public double PrismBaseThickness { get; set; }

        [Required]
        public double MinimumEdgeThickness { get; set; }

        public double Result { get; set; }
    }
}
