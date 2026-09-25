using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeNoAdsIconController : JMonoBehaviour
	{
		[SerializeField]
		private GameObject noAdsIcon;

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private bool ShouldShowIcon()
		{
			return false;
		}

		private void OnPurchaseNoAdsHandler(ref AEventManager.OnPurchaseNoAds eventData)
		{
		}
	}
}
