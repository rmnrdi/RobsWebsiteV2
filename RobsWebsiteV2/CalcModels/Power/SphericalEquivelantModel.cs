using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.Power
{
    public class SphericalEquivelantModel
    {
        [Required]
        [Range(-30,30)]
        public double Sphere { get; set; }

        [Required]
        [Range(-30, 0)]
        public double Cylinder { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
