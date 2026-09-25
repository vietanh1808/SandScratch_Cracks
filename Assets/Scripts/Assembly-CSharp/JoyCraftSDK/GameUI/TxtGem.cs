using DG.Tweening;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class TxtGem : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private bool isInGameplayScreen;

		[SerializeField]
		private TextMeshProUGUI gemText_normal;

		[SerializeField]
		private TextMeshProUGUI gemText_hard;

		[SerializeField]
		private TextMeshProUGUI gemText_veryHard;

		[SerializeField]
		private float animTime;

		[SerializeField]
		private float delayTime;

		private int startGemValue;

		private Tween gemTween;

		private void UpdateData()
		{
		}

		private string GetPrefix(int index)
		{
			return null;
		}

		private void SetGem(int gem)
		{
		}

		private void AddTestGem(int gem)
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnGemChange(ref AEventManager.OnGemChange eventData)
		{
		}

		private void OnGameThemeChange(GameTheme theme)
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
