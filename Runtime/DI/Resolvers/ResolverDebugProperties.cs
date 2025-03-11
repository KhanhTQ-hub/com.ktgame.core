using System.Collections.Generic;

namespace com.ktgame.core.di
{
    public sealed class ResolverDebugProperties
    {
        public int Resolutions;
        public List<(object, List<CallSite>)> Instances { get; } = new List<(object, List<CallSite>)>();
        public List<CallSite> BindingCallsite { get; } = new List<CallSite>();
    }
}
