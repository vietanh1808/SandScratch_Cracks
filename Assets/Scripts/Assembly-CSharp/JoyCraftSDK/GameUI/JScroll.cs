using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JScroll : AScroll
	{
		[SerializeField]
		private EnhancedScrollerCellView demoCellView;

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
