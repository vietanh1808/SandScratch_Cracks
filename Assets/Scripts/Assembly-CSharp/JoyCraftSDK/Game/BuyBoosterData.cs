using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "BuyBoosterData", menuName = "GameSDK/BuyBoosterData")]
	public class BuyBoosterData : JScriptableObject
	{
		public BoosterType boosterType;

		public Sprite iconSprite;

		public int totalBonus;

		public string title;

		public string description;

		public int totalCoin;
	}
}
