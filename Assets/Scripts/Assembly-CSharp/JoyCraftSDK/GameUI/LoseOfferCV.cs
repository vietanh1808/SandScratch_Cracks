using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LoseOfferCV : JCellView
	{
		private const string Group_Config = "Config";

		private const string Group_References = "References";

		[SerializeField]
		private float defaultCellSize;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI desc;

		[SerializeField]
		private TextMeshProUGUI price;

		[SerializeField]
		private Button buy;

		private string productID;

		public float CellSize => 0f;

		public void SetData(LoseOfferData data)
		{
		}

		private void OnClickBuy()
		{
		}

		private void OnBuyComplete()
		{
		}

		private void OnBuyFail()
		{
		}
	}
}
