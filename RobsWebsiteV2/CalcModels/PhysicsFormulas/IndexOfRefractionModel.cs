using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class IndexOfRefractionModel
    {
        [Required]
        public double SpeedOfLightInMaterial { get; set; }

        public double Result { get; set; }
    }
}
