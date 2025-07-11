using System;

namespace com.ktgame.core.di
{
	internal sealed class TransientFactoryResolver : IResolver
	{
		private readonly Func<Injector, object> _factory;
		private readonly DisposableCollection _disposables = new DisposableCollection();
		public Lifetime Lifetime => Lifetime.Transient;

		public TransientFactoryResolver(Func<Injector, object> factory)
		{
			Diagnosis.RegisterCallSite(this);
			_factory = factory;
		}

		public object Resolve(Injector injector)
		{
			Diagnosis.IncrementResolutions(this);
			var instance = _factory.Invoke(injector);
			_disposables.TryAdd(instance);
			Diagnosis.RegisterInstance(this, instance);
			return instance;
		}

		public void Dispose()
		{
			_disposables.Dispose();
		}
	}
}
