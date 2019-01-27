using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Models
{
    public enum EyeSide
    {
        Right=0,
        Left=1
    }
    public class Lens
    {
        public double FrontPower { get; set; }
        public double BackPower { get; set; }

        public double LensPower { get; set; }

        public double SpherePower { get; set; }
        public double CylinderPower { get; set; }
        public double CylinderAxis { get; set; }

        public EyeSide eyeside { get; set; }

    }
    

 }
