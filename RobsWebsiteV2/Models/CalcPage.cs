using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RobsWebsiteV2.Models
{
    public class CalcPage
    {
        public static List<Type> GetDLLTypes()
        {
            Assembly calcAssembly = Assembly.Load("OpticianMathLibrary");
            Type[] calcType = calcAssembly.GetTypes();

            var typ = from tp in calcType
                      where
                      !((tp.Name.Contains("NumberRounder")) || (tp.Name.Contains("TextFormatter")))
                      select tp;

            return typ.ToList();
        }
    }
}
