using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ABattlePassConfig : ALiveEventConfig
	{
		[Tooltip("SKU premium (Consumable). Rỗng = không bán premium; đổi ID sau khi khai dashboard = lệch mapping.")]
		[IAPProductID]
		[SerializeField]
		private string premiumProductID;

		[Tooltip("Key thưởng khi thắng 1 level Normal.")]
		[SerializeField]
		private int keyPerWinNormal;

		[Tooltip("Key thưởng khi thắng 1 level Hard.")]
		[SerializeField]
		private int keyPerWinHard;

		[Tooltip("Key thưởng khi thắng 1 level VeryHard.")]
		[SerializeField]
		private int keyPerWinVeryHard;

		[Tooltip("Cứ mỗi X mốc free Battle Pass đã nhận phải xem ad mới nhận tiếp (key/bậc mở không bị chặn). 0 = tắt ad-gate.")]
		[FormerlySerializedAs("levelsPerAdGate")]
		[SerializeField]
		private int tiersPerAdGate;

		public string PremiumProductID => null;

		public int TiersPerAdGate => 0;

		public int GetKeyPerWin(ReleaseDifficulty difficulty)
		{
			return 0;
		}
	}
}
