using System;

namespace com.ktgame.core.di
{
	internal sealed class PropertyInjectorException : Exception
	{
		public PropertyInjectorException(Exception e) : base(e.Message) { }
	}
}
