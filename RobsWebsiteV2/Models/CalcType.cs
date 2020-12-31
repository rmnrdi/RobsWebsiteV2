using System.Collections.Generic;

namespace RobsWebsiteV2.Models
{
    public class CalcType
    {
        public int CalcTypeId { get; set; }
        public string CalcTypeName { get; set; }

        public virtual List<Calculations> Calcs{ get; set; }
    }
}
