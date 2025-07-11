using System;

namespace com.ktgame.core.di
{
	internal sealed class TransientValueResolver : IResolver
	{
		private object _value;
		private readonly DisposableCollection _disposables = new DisposableCollection();
		public Lifetime Lifetime => Lifetime.Transient;

		public TransientValueResolver(object value)
		{
			Diagnosis.RegisterCallSite(this);
			Diagnosis.RegisterInstance(this, value);
			_value = value;
			_disposables.TryAdd(value);
		}

		public object Resolve(Injector injector)
		{
			Diagnosis.IncrementResolutions(this);
			
			if (_value == null)
			{
				throw new Exception("Trying to resolve a second time from a TransientValueResolver");
			}

			var value = _value;
			_value = null;
			Diagnosis.ClearInstances(this);
			return value;
		}

		public void Dispose()
		{
			_disposables.Dispose();
		}
	}
}
