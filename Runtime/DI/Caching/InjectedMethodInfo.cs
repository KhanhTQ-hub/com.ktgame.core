using System.Reflection;

namespace com.ktgame.core.di
{
    internal sealed class InjectedMethodInfo
    {
        public readonly MethodInfo MethodInfo;
        public readonly ParameterInfo[] Parameters;

        public InjectedMethodInfo(MethodInfo methodInfo)
        {
            MethodInfo = methodInfo;
            Parameters = methodInfo.GetParameters();
        }
    }
}
