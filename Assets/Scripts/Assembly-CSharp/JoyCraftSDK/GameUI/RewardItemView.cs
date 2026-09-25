using System;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class RewardItemView : JMonoBehaviour
	{
		private const string Group_References = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private Image _imgIcon;

		[SerializeField]
		private TextMeshProUGUI _txtAmount;

		[SerializeField]
		private CanvasGroup _flashOverlay;

		[SerializeField]
		private float _countUpDuration;

		[SerializeField]
		private float _landPunchStrength;

		[SerializeField]
		private float _landPunchDuration;

		[SerializeField]
		private float _breatheScale;

		[SerializeField]
		private float _breatheDuration;

		public RewardDisplayData RewardDisplay { get; private set; }

		public Transform IconTransform => null;

		public void Init(RewardDisplayData rewardDisplay, Sprite icon)
		{
		}

		public void PlayReveal(float delay, float popDuration, Ease popEase, Action onRevealed = null)
		{
		}

		private void StartBreathe()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
