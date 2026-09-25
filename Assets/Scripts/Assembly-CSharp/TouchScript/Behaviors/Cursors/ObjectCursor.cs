using System.Text;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_ObjectCursor.htm")]
	public class ObjectCursor : TextPointerCursor<ObjectPointer>
	{
		public bool ShowObjectId;

		public bool ShowSize;

		public bool ShowAngle;

		protected override void generateText(ObjectPointer pointer, StringBuilder str)
		{
		}

		protected override bool textIsVisible()
		{
			return false;
		}

		protected override uint gethash(ObjectPointer pointer)
		{
			return 0u;
		}
	}
}
