using System.Collections.Generic;

namespace JoyCraftSDK.GameUI
{
	public class ShopContentManager : AShopContentManager
	{
		public override IReadOnlyList<ShopSection> GetContent()
		{
			return null;
		}

		public override IReadOnlyList<ShopCardEntry> GetLoseOffers()
		{
			return null;
		}

		private bool IsCardAvailable(ShopCardEntry card)
		{
			return false;
		}

		private bool IsUnlockRuleMet(ShopUnlockRule rule)
		{
			return false;
		}

		private bool IsBattlePassPremiumAvailable()
		{
			return false;
		}

		private bool IsAllBoostersUnlocked()
		{
			return false;
		}
	}
}
