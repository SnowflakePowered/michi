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
        internal static Tuple<string[], Dictionary<string, Type>> GetParameterData(this MethodInfo @methodInfo)
        {
            
            ParameterInfo[] parameterInfos = @methodInfo.GetParameters();
            string[] parameterNames = new string[parameterInfos.Length];
            foreach (var param in parameterInfos)
            {
                parameterNames[param.Position] = param.Name; //must preserve order
            }
            return Tuple.Create(parameterNames, parameterInfos.ToDictionary(param => param.Name, param => param.ParameterType));
        }
    }
}
