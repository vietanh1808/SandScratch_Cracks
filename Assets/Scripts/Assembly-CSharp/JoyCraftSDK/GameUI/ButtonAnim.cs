using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Button), typeof(CanvasGroup))]
	public class ButtonAnim : AButtonAnim
	{
		[Serializable]
		public enum ShowAnimType
		{
			None = 0,
			FadeIn = 1,
			FromScale = 2
		}

		[Serializable]
		public enum PressAnimType
		{
			None = 0,
			Scale = 1,
			FaceScale = 2
		}

		[Serializable]
		public enum HideAnimType
		{
			None = 0,
			FadeOut = 1,
			ToScale = 2
		}

		private const string Group_General = "General";

		private const string Group_Show = "Show Anim";

		private const string Group_Press = "Press Anim";

		private const string Group_Hide = "Hide Anim";

		[SerializeField]
		private bool unscaleTime;

		[SerializeField]
		private ShowAnimType showAnimType;

		[SerializeField]
		private float showAnimTime;

		[SerializeField]
		private float initScale;

		[SerializeField]
		private bool separateAxisShowAnim;

		public EasingType showAnimEasingType;

		public AnimationCurve showAnimCurve;

		public EasingType showAnimXAxisEasingType;

		public AnimationCurve showAnimXAxisCurve;

		public EasingType showAnimYAxisEasingType;

		public AnimationCurve showAnimYAxisCurve;

		[SerializeField]
		private PressAnimType pressAnimType;

		[SerializeField]
		private float pressAnimTime;

		[SerializeField]
		private float releaseAnimTime;

		[SerializeField]
		private Vector2 pressedTargetScale;

		[SerializeField]
		private RectTransform _face;

		[SerializeField]
		private Image _faceImage;

		[SerializeField]
		private Color _pressedTint;

		[SerializeField]
		private EasingType pressAnimEasingType;

		[SerializeField]
		private AnimationCurve pressAnimCurve;

		[SerializeField]
		private EasingType releaseAnimEasingType;

		[SerializeField]
		private AnimationCurve releaseAnimCurve;

		[SerializeField]
		private HideAnimType hideAnimType;

		[SerializeField]
		private float hideAnimTime;

		public float targetScale;

		public bool separateAxisHideAnim;

		public EasingType hideAnimEasingType;

		public AnimationCurve hideAnimCurve;

		public EasingType hideAnimXAxisEasingType;

		public AnimationCurve hideAnimXAxisCurve;

		public EasingType hideAnimYAxisEasingType;

		public AnimationCurve hideAnimYAxisCurve;

		private Button _btn;

		private CanvasGroup _canvasGroup;

		private Vector3 _faceOrigScale;

		private Color _faceOrigColor;

		private bool ShowButtonAnim => false;

		private bool ShowShowAnimEasingType => false;

		private bool ShowSeparateShowAnimEasingType => false;

		private bool UseShowAnimCurve => false;

		private bool UseXAxisShowAnimCurve => false;

		private bool UseYAxisShowAnimCurve => false;

		private bool ShowPressedScale => false;

		private bool UsePressAnimCurve => false;

		private bool UseReleaseAnimCurve => false;

		private bool ShowHideAnimEasingType => false;

		private bool ShowSeparateHideAnimEasingType => false;

		private bool UseHideAnimCurve => false;

		private bool UseXAxisHideAnimCurve => false;

		private bool UseYAxisHideAnimCurve => false;

		private void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void ShowAnim(Action onComplete = null)
		{
		}

		public override void HideAnim(Action onComplete = null)
		{
		}

		private void PointerDownAnim()
		{
		}

		private void PointerUpAnim()
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
