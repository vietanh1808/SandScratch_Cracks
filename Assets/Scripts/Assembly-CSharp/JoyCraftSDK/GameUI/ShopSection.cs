using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class ShopSection : JBase
	{
		[SerializeField]
		private string label;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private List<ShopCardEntry> cards;

		public string Label => null;

		public Sprite Icon => null;

		public IReadOnlyList<ShopCardEntry> Cards => null;

		public ShopSection()
		{
		}

		public ShopSection(string label, Sprite icon, List<ShopCardEntry> cards)
		{
		}
	}
}
