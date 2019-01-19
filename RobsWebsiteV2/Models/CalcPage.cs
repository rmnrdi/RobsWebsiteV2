using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using OpticianMathLibrary;

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

        public static List<MethodInfo> GetMethodNames(string className)
        {
            Assembly calcAssembly = Assembly.Load("OpticianMathLibrary");
            Type calcType = calcAssembly.GetType("OpticianMathLibrary." + className);

            MethodInfo[] methodInfos = calcType.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase);

            return methodInfos.ToList();
        }
    }
}
