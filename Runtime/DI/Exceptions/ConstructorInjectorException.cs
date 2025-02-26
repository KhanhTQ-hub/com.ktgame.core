using System;

namespace com.ktgame.core.di
{
	internal sealed class ConstructorInjectorException : Exception
	{
		public ConstructorInjectorException(Type type, Exception e) : base(BuildMessage(type, e)) { }

		private static string BuildMessage(Type type, Exception e)
		{
			return $"Error occurred while instantiating object type '{type.GetFullName()}'\n\n{e.Message}";
		}
	}
}
