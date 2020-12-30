using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.OpticianFormulas
{
    public class SegDropModel
    {
        [Required]
        [Range(5, 30)]
        public double SegHeight { get; set; }

        [Required]
        [Range(10, 70)]
        public double BMeasurement { get; set; }


        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }

}
