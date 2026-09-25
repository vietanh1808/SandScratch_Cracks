using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelProgress : ALevelProgress
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private JSlider levelProgress;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private LevelProgressConfig config;

		[SerializeField]
		private RectTransform deadIcon;

		[SerializeField]
		private RectTransform normalIcon;

		private Tween progressTween;

		private float targetValue;

		private Slider slider => null;

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

		private void UpdateUI()
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnValidate()
		{
		}
	}
}
