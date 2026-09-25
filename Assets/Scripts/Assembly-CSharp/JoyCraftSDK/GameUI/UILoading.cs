using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class UILoading : AUILoading
	{
		public Image sliderImg;

		public Image sliderImg2;

		public Transform sliderMain;

		public float scaleValueNormalScreen;

		public float scaleValueWideScreen;

		public TMP_Text percentTxt;

		private float progress;

		private Sequence tween;

		public override void Awake()
		{
		}

		private void OnChangeProgress(float value)
		{
		}

		private void Setup()
		{
		}

		public override void ChangeLoadingBackground(Sprite sprite)
		{
		}

		public override void Write(string s)
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void Progress(float to, float speed)
		{
		}
	}
}
