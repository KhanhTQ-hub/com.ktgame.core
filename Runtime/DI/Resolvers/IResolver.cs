using System;

namespace com.ktgame.core.di
{
    public interface IResolver : IDisposable
    {
        Lifetime Lifetime { get; }
        object Resolve(Injector injector);
    }
}
