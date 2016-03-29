using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Michi.Functions
{
    internal static class MethodInfoExtensions
    {
        internal static string[] GetParameterNames(this MethodInfo @methodInfo)
        {
            ParameterInfo[] parameterInfos = @methodInfo.GetParameters();
            string[] parameterNames = new string[parameterInfos.Length];
            foreach (var param in parameterInfos)
            {
                parameterNames[param.Position] = param.Name; //must preserve order
            }
            return parameterNames;
        }
    }
}
