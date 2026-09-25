using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JPagesScrollVertical : JPagesScrollBase
	{
		protected override EnhancedScroller.ScrollDirectionEnum ScrollDir => EnhancedScroller.ScrollDirectionEnum.Vertical;

		protected override float AxisOf(Vector2 localPoint)
		{
			return 0f;
		}

		protected override int StepFromDrag(float dragDelta)
		{
			return 0;
		}
	}
}
