using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class HomeTabBtn : JTabBtn
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

		private Sequence tween;

		private Vector2 initIconSize;

		private bool initAlready;

		protected override void OnDestroy()
		{
		}

		private void Init()
		{
		}

		public override void Awake()
		{
		}

		public override void OnDeselect()
		{
		}

		public override void OnSelect()
		{
		}

		public override void SetPage(ATabPage page)
		{
		}

		private void SetDeactive()
		{
		}

		private void SetActive()
		{
		}
	}
}
