using com.ktgame.core.di.editor;
using UnityEditor;

namespace com.ktgame.core.editor
{
	internal static class MenuItems
	{
		[MenuItem("Ktgame/Dependency Container Debugger", priority = 4999)]
		public static void OpenReflexDebuggingWindow()
		{
			EditorWindow.GetWindow<DiDebuggerWindow>(false, "Di Debugger", true);
		}
	}
}
