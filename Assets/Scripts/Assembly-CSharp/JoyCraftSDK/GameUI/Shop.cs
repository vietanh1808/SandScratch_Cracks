using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class Shop : JMonoBehaviour
	{
		[SerializeField]
		private ShopScroll scroll;

		[SerializeField]
		private ShopIndexBar indexBar;

		protected override void OnEnable()
		{
		}

		public void SetContent(IReadOnlyList<ShopSection> sections)
		{
		}
	}
}
