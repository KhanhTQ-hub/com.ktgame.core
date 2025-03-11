using System.Runtime.CompilerServices;

namespace com.ktgame.core.di
{
    public static class InjectExtensions
    {
        private static readonly ConditionalWeakTable<Injector, DebugProperties> _containerDebugProperties = new ConditionalWeakTable<Injector, DebugProperties>();

        public static DebugProperties GetDebugProperties(this Injector container)
        {
            return _containerDebugProperties.GetOrCreateValue(container);
        }
    }
}
