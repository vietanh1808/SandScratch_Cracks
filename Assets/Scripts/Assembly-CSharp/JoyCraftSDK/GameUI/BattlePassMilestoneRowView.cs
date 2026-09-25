using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassMilestoneRowView : JCellView
	{
		private const string Group_Refs = "References";

		private const string Group_TierState = "Tier State";

		[SerializeField]
		private BattlePassMilestoneView freeSide;

		[SerializeField]
		private BattlePassMilestoneView premiumSide;

		[Tooltip("Số BẬC của hàng (1..N) — nhãn thứ tự, KHÔNG phải giá key.")]
		[SerializeField]
		private TextMeshProUGUI tierText;

		[Tooltip("Node 'Level State' — hình báo bậc đã mở hay còn khoá. Cả 3 slot Tier State là MỘT CỤM: thiếu 1 cái là tắt hẳn, hàng giữ nguyên sprite dựng sẵn trong prefab.")]
		[SerializeField]
		private Image levelStateImage;

		[Tooltip("Sprite khi bậc ĐÃ mở (key tích lũy đã trả nổi chi phí cộng dồn tới bậc này).")]
		[SerializeField]
		private Sprite unlockedSprite;

		[Tooltip("Sprite khi bậc CHƯA mở.")]
		[SerializeField]
		private Sprite lockedSprite;

		private int tier;

		private ABattlePassManager _battlePassManager => null;

		public void SetData(LiveEventMilestoneTier milestoneTier, BattlePassRewardPreviewRouter router)
		{
		}

		public override void RefreshCellView()
		{
		}

		private void ApplyTierState()
		{
		}
	}
}
