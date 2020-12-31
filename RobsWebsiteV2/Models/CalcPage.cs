using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RobsWebsiteV2.Models
{
    public class CalcPage
    {
        public CalcTypes CalulationTypes{ get; set; }

        public static List<Type> GetCalcTypes()
        {
            Assembly calcAssembly = Assembly.Load("OpticianMathLibrary");
            Type[] calcType = calcAssembly.GetTypes();

            var typ = from tp in calcType
                      where
                      !((tp.Name.Contains("NumberRounder")) || (tp.Name.Contains("TextFormatter")))
                      select tp;

            return typ.ToList();
        }

        public static List<MethodInfo> GetCalcNames(string className)
        {
            Assembly calcAssembly = Assembly.Load("OpticianMathLibrary");
            Type calcType = calcAssembly.GetType("OpticianMathLibrary." + className);

            MethodInfo[] methodInfos = calcType.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase);

            return methodInfos.ToList();
        }

        public enum CalcTypes
        {
            BaseCurve,
            Magnification,
            OpticianFormulas,
            PhysicsFormulas,
            Power,
            Prism,
            Thickness,
            Tilt,
            Tools,
            Transposition

        }
    }
}
