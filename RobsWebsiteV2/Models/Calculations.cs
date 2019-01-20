using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.Models
{
    public class Calculations
    {
        [Key]
        public int CalcId { get; set; }

        public string CalcName { get; set; }
    }
}