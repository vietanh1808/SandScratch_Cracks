using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class TestUIScroll : AScroll
	{
		[SerializeField]
		private EnhancedScrollerCellView testCVBtn;

		[SerializeField]
		private EnhancedScrollerCellView testCVCanvasImg;

		[SerializeField]
		private EnhancedScrollerCellView testCVSliders;

		[SerializeField]
		private EnhancedScrollerCellView testCVCheckBoxToggle;

		[SerializeField]
		private EnhancedScrollerCellView testInputFieldDropdown;

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

		private EnhancedScrollerCellView SetupTestCellViewBtn(EnhancedScroller enhancedScroller)
		{
			return null;
		}

		private EnhancedScrollerCellView SetupTestCellViewCanvasImg(EnhancedScroller enhancedScroller)
		{
			return null;
		}

		private EnhancedScrollerCellView SetupTestCellViewSliders(EnhancedScroller enhancedScroller)
		{
			return null;
		}

		private EnhancedScrollerCellView SetupTestCellViewCheckBoxToggle(EnhancedScroller enhancedScroller)
		{
			return null;
		}

		private EnhancedScrollerCellView SetupTestInputFieldDropdown(EnhancedScroller enhancedScroller)
		{
			return null;
		}
	}
}
