using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Thickness
{
    public class CenterThicknessModel
    {
        [Required]
        public double SagittalFront { get; set; }

        [Required]
        public double SagittalBack { get; set; }

        [Required]
        public double EdgeThickness { get; set; }

        public double Result { get; set; }

    }
}
