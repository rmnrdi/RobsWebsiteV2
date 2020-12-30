using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.PhysicsFormulas
{
    public class IlluminationModel
    {
        [Required]
        public double Distance { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
