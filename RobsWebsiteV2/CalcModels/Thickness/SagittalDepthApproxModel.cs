using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels
{
    public class SagittalDepthApproxModel
    {
        [Required]
        public double RadiusOfCurvature { get; set; }

        [Required]
        public double LensDiameter { get; set; }

        public double Result { get; set; }
    }
}
