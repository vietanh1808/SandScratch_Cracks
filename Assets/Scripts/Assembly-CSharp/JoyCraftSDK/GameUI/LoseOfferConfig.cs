using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "LoseOfferConfig", menuName = "GameSDK/LoseOfferConfig")]
	public class LoseOfferConfig : ALoseOfferConfig
	{
		[SerializeField]
		private List<LoseOfferData> offers;

		public override IReadOnlyList<LoseOfferData> Offers => null;
	}
}
