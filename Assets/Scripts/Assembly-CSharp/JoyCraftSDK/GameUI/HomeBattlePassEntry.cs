using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class HomeBattlePassEntry : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private GameObject battlePassIcon;

		[SerializeField]
		private Image battlePassImage;

		[SerializeField]
		private Sprite lockedSprite;

		[SerializeField]
		private Sprite unlockedSprite;

		[SerializeField]
		private TextMeshProUGUI keyBadgeText;

		private ABattlePassManager _battlePassManager => null;

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void Refresh()
		{
		}

		private void OnCurrencyChanged(ref AEventManager.OnLiveEventCurrencyChanged eventData)
		{
		}
	}
}
