using System.Collections.Generic;

namespace com.ktgame.core.di
{
    public sealed class DebugProperties
    {
        public List<CallSite> BuildCallsite { get; } = new List<CallSite>();
    }
}
