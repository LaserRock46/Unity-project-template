using UnityEditor;
using UnityEngine;
using Unity.EditorCoroutines.Editor;
using System.Collections;


namespace FuguFirecracker.TakeNote
{
	internal partial class Window : EditorWindow
	{
		#region UIFields

		internal string TaskString;
		internal string DetailsString;
		internal bool DoAdd;
		internal bool DoDetails;
		internal bool DoColor;
		internal Color ColorizeColor = Color.white;

		internal Color TaskAlertColor = Color.white;
		private Vector2 _scrollVector;

		#endregion


		[MenuItem("Take Note/Take Note")]
		public static void OpenWindow()
		{
			GetWindow<Window>("Take Note");
		}
	}

	[InitializeOnLoad]
	public class Startup
	{	
		static Startup()
		{
			if (!SessionState.GetBool("FirstInitDone", false))
			{
				EditorCoroutineUtility.StartCoroutineOwnerless(PrintEachSecond());
				SessionState.SetBool("FirstInitDone", true);
			}
		}
		static IEnumerator PrintEachSecond()
		{
			var waitForOneSecond = new EditorWaitForSeconds(1.0f);

			yield return waitForOneSecond;

			Window.OpenWindow();

		}
	}
}