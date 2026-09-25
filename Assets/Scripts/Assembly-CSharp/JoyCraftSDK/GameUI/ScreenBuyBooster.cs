using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class ScreenBuyBooster : JUIPanel
	{
		public BoosterType boosterType;

		public TMP_Text indexTxt;

		public TMP_Text titleTxt;

		public TMP_Text descriptionTxt;

		public TMP_Text coinTxt;

		public Image iconImg;

		public Button buyBtn;

		[SerializeField]
		private BtnWatchAdForBooster watchAdBtn;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		private void Start()
		{
		}

		public void OnBuy()
		{
		}

		protected override void OnEnable()
		{
		}

		private void Setup()
		{
		}
	}
}
