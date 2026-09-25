using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.Game
{
	public class HandCursor : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform handRect;

		[SerializeField]
		private Image handImage;

		[Header("Click Animation")]
		[SerializeField]
		private float clickScale;

		[SerializeField]
		private float clickDuration;

		private Vector3 originalScale;

		private Tween clickTween;

		private bool isVisible;

		public override void Awake()
		{
		}

		private void Update()
		{
		}

		private void SetVisible(bool visible)
		{
		}

		private void PlayClickAnim()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
