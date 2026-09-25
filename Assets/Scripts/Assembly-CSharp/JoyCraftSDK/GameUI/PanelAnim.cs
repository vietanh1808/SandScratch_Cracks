using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class PanelAnim : APanelAnim
	{
		[Space]
		[Header("Others")]
		public bool unscaleTime;

		[SerializeField]
		public RectTransform popup;

		public CanvasGroup rootGraphic;

		private Vector3 _initLocalPosition;

		private IAnimationTarget _target;

		private CanvasGroup _popupGraphic;

		[Header("Anim In")]
		public AnimInType animIn;

		public UnityEvent animInCompletedEvent;

		public float animInTime;

		public float delayAnimIn;

		public float initScale;

		public bool separateAxisAnimIn;

		public EasingType animInEasingType;

		public AnimationCurve animInCurve;

		public EasingType animInXAxisEasingType;

		public AnimationCurve animInXAxisCurve;

		public EasingType animInYAxisEasingType;

		public AnimationCurve animInYAxisCurve;

		[Space]
		[Header("Anim Out")]
		public AnimOutType animOut;

		public UnityEvent animOutCompletedEvent;

		public float animOutTime;

		public float targetScale;

		public bool separateAxisAnimOut;

		public EasingType animOutEasingType;

		public AnimationCurve animOutCurve;

		public EasingType animOutXAxisEasingType;

		public AnimationCurve animOutXAxisCurve;

		public EasingType animOutYAxisEasingType;

		public AnimationCurve animOutYAxisCurve;

		private bool UsePopupAnim => false;

		private bool ShowAnimInEasingType => false;

		private bool ShowSeparateAnimInEasingType => false;

		private bool UseAnimInCurve => false;

		private bool UseXAxisAnimInCurve => false;

		private bool UseYAxisAnimInCurve => false;

		private bool ShowAnimOutEasingType => false;

		private bool ShowSeparateAnimOutEasingType => false;

		private bool UseAnimOutCurve => false;

		private bool UseXAxisAnimOutCurve => false;

		private bool UseYAxisAnimOutCurve => false;

		private void OnValidate()
		{
		}

		public override void Setup(IAnimationTarget target)
		{
		}

		public override void StartAnimIn()
		{
		}

		public override void OnAnimInComplete()
		{
		}

		public override void StartAnimOut()
		{
		}

		public override void OnAnimOutComplete()
		{
		}

		public override bool AnimOutAvailable()
		{
			return false;
		}

		private void ValidatePopupRect()
		{
		}

		private void ResetBeforeAnim()
		{
		}

		private void ApplyEase(Tween tween, bool useCurve, AnimationCurve curve, Ease ease)
		{
		}
	}
}
