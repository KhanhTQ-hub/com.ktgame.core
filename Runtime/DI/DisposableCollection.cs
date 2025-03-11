using System;
using System.Collections.Generic;

namespace com.ktgame.core.di
{
    internal sealed class DisposableCollection : IDisposable
    {
        private readonly Stack<IDisposable> _stack = new Stack<IDisposable>();

        public void Add(IDisposable disposable)
        {
            _stack.Push(disposable);
        }

        public void TryAdd(object obj)
        {
            if (obj is IDisposable disposable)
            {
                _stack.Push(disposable);
            }
        }

        public void Remove(IDisposable disposable)
        {
#if UNITY_2020_3
			TryPop(out _);
#else
            _stack.TryPop(out _);
#endif
        }

        public void Dispose()
        {
#if UNITY_2020_3
			while (TryPop(out var disposable))
#else
            while (_stack.TryPop(out var disposable))
#endif
            {
                disposable.Dispose();
            }
        }
		
#if UNITY_2020_3
		public bool TryPop(out IDisposable disposable)
		{
			if (_stack.Count > 0)
			{
				disposable = _stack.Pop();
				return true;
			}

			disposable = null;
			return false;
		}
#endif
    }
}