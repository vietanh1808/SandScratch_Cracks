using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AShopContentConfig : JScriptableObject
	{
		public abstract IReadOnlyList<ShopSection> Sections { get; }
	}
}
