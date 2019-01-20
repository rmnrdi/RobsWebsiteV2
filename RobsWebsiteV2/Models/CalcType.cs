using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Models
{
    public class CalcType
    {
        public int CalcTypeId { get; set; }
        public string CalcTypeName { get; set; }

        public virtual List<Calculations> Calcs{ get; set; }
    }
}
