using TouchScript.InputSources;
using UnityEngine;

namespace TouchScript.Pointers
{
	public class MousePointer : Pointer
	{
		public Vector2 ScrollDelta { get; set; }

		public MousePointer(IInputSource input)
			: base(null)
		{
		}

		public override void CopyFrom(Pointer target)
		{
		}
	}
}
