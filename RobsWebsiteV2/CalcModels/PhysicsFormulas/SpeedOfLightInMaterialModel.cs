using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class SpeedOfLightInMaterialModel
    {
        [Required]
        public double IndexOfRefraction { get; set; }

        [Required]
        public double Result { get; set; }
    }
}
