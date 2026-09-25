using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;

namespace JoyCraftSDK.GameUI
{
	public class ShopScroll : AScroll
	{
		private List<ShopCellData> cells;

		private float[] cachedCellSizes;

		public void SetCells(List<ShopCellData> cellDatas)
		{
		}

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
