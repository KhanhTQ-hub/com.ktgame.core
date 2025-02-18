using System;
using Cysharp.Threading.Tasks;

namespace com.ktgame.core.manager
{
	public interface IManager : IDisposable
	{
		int Priority { get; }

		bool IsInitialized { get; }

		UniTask Initialize();
	}
}
