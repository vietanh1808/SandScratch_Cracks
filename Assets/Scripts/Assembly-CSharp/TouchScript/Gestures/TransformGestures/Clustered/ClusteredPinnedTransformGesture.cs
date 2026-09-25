using System.Collections.Generic;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures.Clustered
{
	[AddComponentMenu("TouchScript/Gestures/Clustered/Pinned Transform Gesture (Clustered)")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TransformGestures_Clustered_ClusteredPinnedTransformGesture.htm")]
	public class ClusteredPinnedTransformGesture : PinnedTransformGesture
	{
		protected override bool relevantPointers(IList<Pointer> pointers)
		{
			return false;
		}

		protected override Vector2 getPointScreenPosition()
		{
			return default;
		}

		protected override Vector2 getPointPreviousScreenPosition()
		{
			return default;
		}
	}
}
