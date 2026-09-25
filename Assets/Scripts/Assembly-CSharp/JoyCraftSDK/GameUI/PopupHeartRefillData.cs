using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "PopupHeartRefillData", menuName = "GameSDK/PopupHeartRefillData")]
	public class PopupHeartRefillData : JScriptableObject
	{
		[Tooltip("Số lượng heart sau khi xem quảng cáo")]
		public int totalWatchAdsBonusHeart;

		[Tooltip("Số lượng heart sau khi mua")]
		public int totalBuyCoinBonusHeart;

		[Tooltip("Số lượng coin khi mua")]
		public int totalSpendCoin;
	}
}
