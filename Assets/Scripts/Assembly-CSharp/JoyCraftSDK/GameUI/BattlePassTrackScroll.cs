using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.LiveEvent;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassTrackScroll : AScroll
	{
		[SerializeField]
		private BattlePassMilestoneRowView rowPrefab;

		[Tooltip("Chiều cao 1 hàng — đo lại theo prefab hàng.")]
		[SerializeField]
		private float cellSize;

		[Tooltip("Node blocker của màn (BattlePassRewardPreviewRouter). Bỏ trống = mốc nhiều reward KHÔNG bấm xem được.")]
		[SerializeField]
		private BattlePassRewardPreviewRouter previewRouter;

		[Tooltip("Cell 0 = banner tag Free|VIP, CUỘN CÙNG list. Bỏ trống = track không có header (hành vi cũ).")]
		[SerializeField]
		private BattlePassColumnHeaderCell headerPrefab;

		[Tooltip("Chiều cao ô header (cell 0). Chỉ dùng khi đã gán headerPrefab.")]
		[SerializeField]
		private float headerSize;

		private IReadOnlyList<LiveEventMilestoneTier> tiers;

		private ABattlePassManager _battlePassManager => null;

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
