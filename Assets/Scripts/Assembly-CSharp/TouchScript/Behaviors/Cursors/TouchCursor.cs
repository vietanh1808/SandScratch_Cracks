using System.Text;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_TouchCursor.htm")]
	public class TouchCursor : TextPointerCursor<TouchPointer>
	{
		public bool ShowPressure;

		public bool ShowRotation;

		protected override void generateText(TouchPointer pointer, StringBuilder str)
		{
		}

		protected override bool textIsVisible()
		{
			return false;
		}

		protected override uint gethash(TouchPointer pointer)
		{
			return 0u;
		}
	}
}
