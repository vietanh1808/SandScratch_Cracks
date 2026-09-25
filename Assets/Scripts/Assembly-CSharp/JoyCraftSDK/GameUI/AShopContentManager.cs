using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AShopContentManager : JBase
	{
		public abstract IReadOnlyList<ShopSection> GetContent();

		public abstract IReadOnlyList<ShopCardEntry> GetLoseOffers();
	}
}
