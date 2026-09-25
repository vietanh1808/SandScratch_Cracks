using System;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BoosterProgressBar : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Anim = "Animation";

		[SerializeField]
		private RectTransform progressRect;

		[SerializeField]
		private RectTransform coinRect;

		[SerializeField]
		private TMP_Text progressTxt;

		[SerializeField]
		private Image bgImg;

		[SerializeField]
		private Image fillImg;

		[SerializeField]
		private RectTransform punchRect;

		[SerializeField]
		private MMF_Player fb_shinyEffect;

		[SerializeField]
		private MMF_Player fb_notShinyEffect;

		[SerializeField]
		private float playTime;

		[SerializeField]
		private float delayTime;

		[SerializeField]
		private float punchScale;

		[SerializeField]
		private float punchTime;

		private UnlockEntry nextUnlock;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void UnlockBooster()
		{
		}

		public void ShowBoosterProgressBar()
		{
		}

		private void ShowBoosterArt(BoosterType type)
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
