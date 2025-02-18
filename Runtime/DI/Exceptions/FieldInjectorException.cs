using System;

namespace com.ktgame.core.di
{
	internal sealed class FieldInjectorException : Exception
	{
		public FieldInjectorException(Exception e) : base(e.Message) { }
	}
}
