using System;

namespace com.ktgame.core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        public Type ServiceType { get; private set; }

        public ServiceAttribute(Type serviceType)
        {
            ServiceType = serviceType;
        }
    }
}