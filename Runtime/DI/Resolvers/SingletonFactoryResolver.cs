using System;

namespace com.ktgame.core.di
{
	internal sealed class SingletonFactoryResolver : IResolver
	{
		private object _instance;
		private readonly Func<Injector, object> _factory;
		private readonly DisposableCollection _disposables = new DisposableCollection();

		public Lifetime Lifetime => Lifetime.Singleton;

		public SingletonFactoryResolver(Func<Injector, object> factory)
		{
			Diagnosis.RegisterCallSite(this);
			_factory = factory;
		}

		public object Resolve(Injector container)
		{
			Diagnosis.IncrementResolutions(this);
            
			if (_instance == null)
			{
				_instance = _factory.Invoke(container);
				_disposables.TryAdd(_instance);
				Diagnosis.RegisterInstance(this, _instance);
			}

			return _instance;
		}

		public void Dispose()
		{
			_disposables.Dispose();
		}
	}
}
