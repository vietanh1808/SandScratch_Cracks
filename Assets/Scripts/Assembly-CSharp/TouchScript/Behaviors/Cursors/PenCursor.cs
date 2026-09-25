using System.Text;
using TouchScript.Behaviors.Cursors.UI;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_PenCursor.htm")]
	public class PenCursor : TextPointerCursor<PenPointer>
	{
		public TextureSwitch DefaultCursor;

		public TextureSwitch PressedCursor;

		public bool ShowButtons;

		public bool ShowPressure;

		public bool ShowRotation;

		protected override void updateOnce(IPointer pointer)
		{
		}

		protected override void generateText(PenPointer pointer, StringBuilder str)
		{
		}

		protected override bool textIsVisible()
		{
			return false;
		}

		protected override uint gethash(PenPointer pointer)
		{
			return 0u;
		}
	}
}
