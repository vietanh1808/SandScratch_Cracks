using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class LoseOfferScroll : AScroll
	{
		[SerializeField]
		private LoseOfferCV cellPrefab;

		private IReadOnlyList<LoseOfferData> offers;

		public void SetData(IReadOnlyList<LoseOfferData> offerList)
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
