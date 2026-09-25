using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupTryRetry : JUIPanel
	{
		[SerializeField]
		private RectTransform brokenHeartRect;

		[SerializeField]
		private RectTransform btnRect;

		[SerializeField]
		private GameObject retryBtn;

		[SerializeField]
		private GameObject quitBtn;

		[SerializeField]
		private GameObject restartBtn;

		[SerializeField]
		private Image titleImg;

		[SerializeField]
		private Sprite failSprite;

		[SerializeField]
		private Sprite quitSprite;

		[SerializeField]
		private Sprite retrySprite;

		public TMP_Text levelTxt;

		public TMP_Text description;

		private RetryState _retryState;

		private GameObject _closeBtn;

		private const float HeartScaleDuration = 0.25f;

		private const float HeartScaleDelay = 0.25f;

		private const float BtnPunchScale = 1.15f;

		private const float BtnPunchDuration = 0.25f;

		private const float BtnPunchDelay = 0.5f;

		private const float BtnSettleDuration = 0.2f;

		private const float BtnSettleDelay = 0.75f;

		public void SetRetryState(RetryState state)
		{
		}

		public bool IsTerminalFail()
		{
			return false;
		}

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		public override void OnAppear()
		{
		}
	}
}
