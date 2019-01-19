using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpticianMathLibrary;

namespace ReflectStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var mNames = GetMethodNames("BaseCurve");

            foreach (var item in mNames)
            {
                Console.WriteLine($"************ {item.Name} *************");
                //GetMethod();
            }
            
            Console.ReadLine();
        }

        private static MethodInfo[] GetMethodNames(string className)
        {
            Assembly calcAssembly = Assembly.LoadFrom("OpticianMathLibrary.dll");
            Type calcType = calcAssembly.GetType("OpticianMathLibrary." + className );

            MethodInfo[] methodInfos = calcType.GetMethods(BindingFlags.Public| BindingFlags.Static);

            return methodInfos;
        }


        private static Type[] GetDLLTypes2()
        {
            Assembly calcAssembly = Assembly.LoadFrom("OpticianMathLibrary.dll");
            Type[] calcType = calcAssembly.GetTypes();

            var typ = from tp in calcType
                      where
                      !((tp.Name.Contains("NumberRounder")) || (tp.Name.Contains("TextFormatter")))
                      select tp;

            return typ.ToArray();
        }

        private static void GetMethodInfo(Type type)
        {
            Assembly calcAssembly = Assembly.LoadFrom("OpticianMathLibrary.dll");

            var myType = type;

            MethodInfo[] methods = myType.GetTypeInfo().GetMethods();

            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }

        }

        private static List<Type> GetDLLTypes()
        {
            Assembly calcAssembly = Assembly.LoadFrom("OpticianMathLibrary.dll");
            Type[] calcType = calcAssembly.GetTypes();

            var typ = from tp in calcType
                      where
                      !((tp.Name.Contains("NumberRounder")) || (tp.Name.Contains("TextFormatter")))
                      select tp;

            return typ.ToList();
        }



    }
}
