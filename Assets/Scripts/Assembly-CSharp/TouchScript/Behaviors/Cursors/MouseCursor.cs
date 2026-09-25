using System.Text;
using TouchScript.Behaviors.Cursors.UI;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_MouseCursor.htm")]
	public class MouseCursor : TextPointerCursor<MousePointer>
	{
		public TextureSwitch DefaultCursor;

		public TextureSwitch PressedCursor;

		public bool ShowButtons;

		protected override void updateOnce(IPointer pointer)
		{
		}

		protected override void generateText(MousePointer pointer, StringBuilder str)
		{
		}

		protected override bool textIsVisible()
		{
			return false;
		}

		protected override uint gethash(MousePointer pointer)
		{
			return 0u;
		}
	}
}
