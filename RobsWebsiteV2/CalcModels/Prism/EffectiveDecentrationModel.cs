using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    public class EffectiveDecentrationModel
    {
        [Required]
        public double HorizontalDecentration { get; set; }

        [Required]
        public double VerticalDecentration { get; set; }

        [Required]
        [Range(1,180,ErrorMessage ="Cylinder axis must be between 1 and 180 degrees")]
        public double CylinderAxis { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}