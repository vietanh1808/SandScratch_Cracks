using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.TrophyRoom;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class TrophyShopScroll : AScroll
	{
		[SerializeField]
		private TrophyItemRowView rowPrefab;

		[Tooltip("Chiều cao 1 hàng — đo lại theo prefab hàng.")]
		[SerializeField]
		private float cellSize;

		private IReadOnlyList<TrophyItemDef> trophyItemDefs;

		public Action<int> OnBuyItem;

		private ATrophyRoomManager _trophyRoomManager => null;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Rebuild()
		{
		}

		public void RefreshVisible()
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
