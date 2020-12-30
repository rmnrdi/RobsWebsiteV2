using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.CalcModels.OpticianFormulas
{
    public class AstigmatismEvaluatorModel
    {
        [Required]
        [Range(-30,30)]
        public double SpherePower { get; set; }

        [Required]
        [Range(-30, 0)]
        public double CylinderPower { get; set; }

        public string Result { get; set; }

    }
}
