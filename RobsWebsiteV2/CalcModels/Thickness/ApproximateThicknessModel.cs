using System.ComponentModel.DataAnnotations;



namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class ApproximateThicknessModel
    {
        [Required]
        [Range(-30, 30)]
        public double SurfacePower { get; set; }

        [Required]
        public double LensDiameter { get; set; }

        [Required]
        [Range(1.498, 1.74)]
        public double Index { get; set; }

        [Required]
        public double LensThickness { get; set; }

        public double Result { get; set; }
    }
}
