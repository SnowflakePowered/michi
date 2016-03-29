using System;
using System.Reflection;

namespace Michi.Functions
{
    public partial struct RemoteFunction
    {
        #region Functions

        public static RemoteFunction Make<TResult>(Func<TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, TResult>(Func<T1, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, TResult>(Func<T1, T2, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
            (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> method)
            => RemoteFunction.Make((Delegate) method);

        #endregion

        #region Actions

        public static RemoteFunction Make(Action method)
           => RemoteFunction.Make((Delegate)method);

        public static RemoteFunction Make<T1>(Action<T1> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2>(Action<T1, T2> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3>(Action<T1, T2, T3> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4>(Action<T1, T2, T3, T4> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6>(
            Action<T1, T2, T3, T4, T5, T6> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
            (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method)
            => RemoteFunction.Make((Delegate) method);


        public static RemoteFunction Make
            <T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> method)
            => RemoteFunction.Make((Delegate) method);

        #endregion

        private static RemoteFunction Make(Delegate method)
        {
            var methodData = method.Method.GetCustomAttribute<RemoteFunctionAttribute>() ??
                             new RemoteFunctionAttribute(method.Method.Name);
            return new RemoteFunction(method.Method, method.Target, methodData.MethodName, methodData.MethodNamespace);
        }
    }
}
