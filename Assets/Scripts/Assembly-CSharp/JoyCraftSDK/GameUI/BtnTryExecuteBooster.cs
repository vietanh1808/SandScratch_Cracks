using JoyCraftSDK.Game;
using JoyCraftSDK.Gameplay;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnTryExecuteBooster : JButton
	{
		private const string Group_Refs = "References";

		private const string Group_Face = "Face";

		[SerializeField]
		private BoosterType boosterType;

		[SerializeField]
		private TextMeshProUGUI countTxt;

		[SerializeField]
		private TextMeshProUGUI unlockLevelTxt;

		[SerializeField]
		private GameObject unlockLevelArea;

		[SerializeField]
		private BtnImage btnImages;

		[SerializeField]
		private LockShakeAnim lockShake;

		[SerializeField]
		private GameObject tempBadgeArea;

		[SerializeField]
		private TextMeshProUGUI tempBadgeTxt;

		[SerializeField]
		private DifficultyDataSO difficultyData;

		[SerializeField]
		private Image faceImage;

		[SerializeField]
		private Sprite faceNormalSprite;

		[SerializeField]
		private Sprite faceLockedSprite;

		[SerializeField]
		private HighlightBoosterAnimation highlight;

		[SerializeField]
		private TutorialHandIndicator preLostHand;

		[SerializeField]
		private bool showPreLostHand;

		private bool isLocked;

		private bool isPreLostActive;

		public BoosterType BoosterType => BoosterType.None;

		protected override bool SkipDoubleClickProtection => false;

		protected override void OnClick()
		{
		}

		private void CheckBoosterState()
		{
		}

		private void UpdateBoosterCount()
		{
		}

		private void UpdateTempBadge()
		{
		}

		private Sprite GetCountBgSprite()
		{
			return null;
		}

		private void SetRevokeBtn(bool isOn)
		{
		}

		private void UpdateBtnOpacity(float rate, float time)
		{
		}

		private void PlayPreLostAnim()
		{
		}

		private void DetachHandAboveButtons()
		{
		}

		private void StopPreLostAnim()
		{
		}

		private void OutOfBooster()
		{
		}

		private void OnPreLost(ref AEventManager.OnPreLost eventData)
		{
		}

		private void OnPreLostEnd(ref AEventManager.OnPreLostEnd eventData)
		{
		}

		private void OnLevelLoseCondition(ref AEventManager.OnLevelLoseCondition eventData)
		{
		}

		private void OnTryExecuteBooster(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void OnRevokeBooster(ref AEventManager.OnRevokeBooster eventData)
		{
		}

		private void OnExecuteBooster(ref AEventManager.OnExecuteBooster eventData)
		{
		}

		private void OnCompleteBoosterExecution(ref AEventManager.OnCompleteBoosterExecution eventData)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnBoosterCountChange(ref AEventManager.OnBoosterCountChange eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
