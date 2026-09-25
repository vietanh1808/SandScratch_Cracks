using System.Collections.Generic;
using TouchScript.Clusters;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures.Clustered
{
	[AddComponentMenu("TouchScript/Gestures/Clustered/Screen Transform Gesture (Clustered)")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TransformGestures_Clustered_ClusteredScreenTransformGesture.htm")]
	public class ClusteredScreenTransformGesture : ScreenTransformGesture
	{
		private Clusters2D clusters;

		protected override void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected override void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected override void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected override void reset()
		{
		}

		protected override int getNumPoints()
		{
			return 0;
		}

		protected override bool relevantPointers1(IList<Pointer> pointers)
		{
			return false;
		}

		protected override bool relevantPointers2(IList<Pointer> pointers)
		{
			return false;
		}

		protected override Vector2 getPointScreenPosition(int index)
		{
			return default;
		}

		protected override Vector2 getPointPreviousScreenPosition(int index)
		{
			return default;
		}
	}
}
