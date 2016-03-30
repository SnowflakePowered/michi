using System;
using System.Reflection;

namespace Michi.Functions
{
    public partial struct RemoteFunction
    {
        #region Functions

        public static RemoteFunction Make<TResult>(Func<TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                            new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(), methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, TResult>(Func<T1, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                           new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, TResult>(Func<T1, T2, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]), p.Param<T2>(paramData.Item1[1])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
            (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13]),
                p.Param<T15>(paramData.Item1[14])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13]),
                p.Param<T15>(paramData.Item1[14]),
                p.Param<T16>(paramData.Item1[15])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }
        #endregion

        #region Actions
        public static RemoteFunction Make(Action method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                            new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(), methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1>(Action<T1> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                           new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2>(Action<T1, T2> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]), p.Param<T2>(paramData.Item1[1])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make<T1, T2, T3>(Action<T1, T2, T3> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4>(Action<T1, T2, T3, T4> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }

        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13]),
                p.Param<T15>(paramData.Item1[14])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }


        public static RemoteFunction Make
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                                     new RemoteFunctionAttribute(method.Method.Name);
            var paramData = method.Method.GetParameterData();
            return new RemoteFunction((p) => method(p.Param<T1>(paramData.Item1[0]),
                p.Param<T2>(paramData.Item1[1]),
                p.Param<T3>(paramData.Item1[2]),
                p.Param<T4>(paramData.Item1[3]),
                p.Param<T5>(paramData.Item1[4]),
                p.Param<T6>(paramData.Item1[5]),
                p.Param<T7>(paramData.Item1[6]),
                p.Param<T8>(paramData.Item1[7]),
                p.Param<T9>(paramData.Item1[8]),
                p.Param<T10>(paramData.Item1[9]),
                p.Param<T11>(paramData.Item1[10]),
                p.Param<T12>(paramData.Item1[11]),
                p.Param<T13>(paramData.Item1[12]),
                p.Param<T14>(paramData.Item1[13]),
                p.Param<T15>(paramData.Item1[14]),
                p.Param<T16>(paramData.Item1[15])),
                methodData.MethodName, methodData.MethodNamespace, paramData.Item2);
        }
        #endregion

    }
}
