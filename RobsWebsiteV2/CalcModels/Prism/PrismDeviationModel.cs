using System.ComponentModel.DataAnnotations;


namespace RobsWebsiteV2.CalcModels.Prism
{
    public class PrismDeviationModel
    {
        public double ApicalAngle { get; set; }
        public double Index { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public double Result { get; set; }
    }
}
