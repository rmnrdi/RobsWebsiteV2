using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class EdgeThicknessModel
    {
        [Required]
        public double SagittalFront { get; set; }

        [Required]
        public double SagittalBack { get; set; }

        [Required]
        public double CenterThickness { get; set; }

        public double Result { get; set; }
    }
}
