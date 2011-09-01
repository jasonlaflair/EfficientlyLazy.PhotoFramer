using System;

namespace EfficientlyLazy.PhotoFramer
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class ServiceFactoryVisibleAttribute : Attribute
    {
    }
}
