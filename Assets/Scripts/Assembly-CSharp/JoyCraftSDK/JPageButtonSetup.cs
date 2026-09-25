using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK
{
	public class JPageButtonSetup : APageButtonSetup
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private Image iconImg;

		[SerializeField]
		private Image bgImg;

		[SerializeField]
		private TMP_Text titleTxt;

		[SerializeField]
		private float animTime;

		[Range(0f, 1f)]
		[SerializeField]
		private float clickIconScalePercent;

		[SerializeField]
		private float selectedIconOffsetY;

		[SerializeField]
		private AnimationCurve progressCurve;

		private Sequence tween;

		private Vector2 initIconSize;

		private Vector2 initIconPos;

		private bool initAlready;

		private bool progressDriven;

		private float lastProgress;

		protected override void OnDestroy()
		{
		}

		public override void Init()
		{
		}

		public override void Awake()
		{
		}

		public override void SetProgress(float progress)
		{
		}

		public override void OnDeselect()
		{
		}

		public override void OnSelect()
		{
		}

		private void ApplyProgress(float progress)
		{
		}

		private void ResetIcon()
		{
		}

		private void HideParts()
		{
		}

		private void ShowParts()
		{
		}
	}
}
