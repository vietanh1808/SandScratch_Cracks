using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class ALoseOfferConfig : JScriptableObject
	{
		public abstract IReadOnlyList<LoseOfferData> Offers { get; }
	}
}
