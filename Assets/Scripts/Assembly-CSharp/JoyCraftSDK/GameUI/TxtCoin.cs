using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class TxtCoin : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private bool isInGameplayScreen;

		[SerializeField]
		private TextMeshProUGUI coinText_normal;

		[SerializeField]
		private TextMeshProUGUI coinText_hard;

		[SerializeField]
		private TextMeshProUGUI coinText_veryHard;

		[SerializeField]
		private float animTime;

		[SerializeField]
		private float delayTime;

		private int startCoinValue;

		private void UpdateData()
		{
		}

		private string GetPrefix(int index)
		{
			return null;
		}

		private void SetCoin(int coin)
		{
		}

		private void AddTestCoin(int coin)
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnCoinChange(ref AEventManager.OnCoinChange eventData)
		{
		}

		private void OnCoinFlyStarted(ref AEventManager.OnCoinFlyStarted eventData)
		{
		}

		private void AnimateTo(int endValue)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
