using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	public class AdminTestScroll : AScroll
	{
		[SerializeField]
		private List<GameObject> cellViewPrefabs;

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

		private AAdminTestCellView ResolveCell(int index)
		{
			return null;
		}

		private EnhancedScrollerCellView SetupTab<T>(T cellViewPrefab) where T : AAdminTestCellView
		{
			return null;
		}
	}
}
