using System;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public enum ShopUnlockRule
	{
		Always = 0,
		NoAdsLevelReached = 1,
		AllBoostersUnlocked = 2,
		BattlePassPremiumAvailable = 3
	}
}
