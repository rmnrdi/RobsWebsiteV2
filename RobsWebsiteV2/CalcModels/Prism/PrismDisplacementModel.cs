using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrismDisplacementModel
    {
        [Required]
        public double PrismDiopters { get; set; }
        public double Distance { get; set; }

        public double Result { get; set; }
    }
}
