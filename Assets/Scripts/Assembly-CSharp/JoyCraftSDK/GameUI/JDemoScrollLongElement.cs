using EnhancedUI.EnhancedScroller;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.GameUI
{
	public class JDemoScrollLongElement : AScroll
	{
		[FormerlySerializedAs("cellViewParkLevel")]
		[SerializeField]
		private JDemoCellView cellViewPlanetLevel;

		public override int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public override float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public override EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
