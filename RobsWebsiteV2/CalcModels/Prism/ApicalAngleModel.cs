using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Prism
{
    public class ApicalAngleModel
    {
        [Required]
        //TODO: Find range for deviation. Assume 90 degrees max?
        public double Deviation { get; set; }

        [Required]
        [Range(1.498,1.80,ErrorMessage ="Choose and index between 1.498 and 1.80")]
        public double Index { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
