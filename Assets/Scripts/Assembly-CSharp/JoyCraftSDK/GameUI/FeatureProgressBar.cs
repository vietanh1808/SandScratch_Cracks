using System;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class FeatureProgressBar : JMonoBehaviour
	{
		[Header("Components")]
		public TMP_Text progressTxt;

		public Image iconImg;

		public Image fillImg;

		public RectTransform punchRect;

		public ParticleSystem unlockFeatureFx;

		[Header("Animation")]
		public float playTime;

		public float delayTime;

		public float punchScale;

		public float punchTime;

		private UnlockEntry nextUnlock;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void UnlockFeature()
		{
		}

		public void ShowFeatureProgressBar()
		{
		}

		private void UpdateFill(float target, Action OnComplete)
		{
		}

		private void CheckProgress(float progress)
		{
		}
	}
}
