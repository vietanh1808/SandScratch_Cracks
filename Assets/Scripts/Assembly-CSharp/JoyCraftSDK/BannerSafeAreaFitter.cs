using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class BannerSafeAreaFitter : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private float _tweenDuration;

		[SerializeField]
		private float _editorPreviewHeightDp;

		private Tween _offsetTween;

		public override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnBannerVisibilityChanged(bool visible, float heightPixels)
		{
		}

		private void ApplyBannerState(bool visible, float heightPixels, bool animate)
		{
		}
	}
}
