using MoreMountains.Feedbacks;
using UnityEngine;

namespace JoyCraftSDK
{
	public class AudioManager : AAudioManager
	{
		private const string Group_FB = "Sound Feedbacks";

		private const string Group_Loop = "Loop Sources (flow)";

		[SerializeField]
		private SoundData soundData;

		[Tooltip("Giãn tối thiểu (giây) giữa 2 lần phát SFX cào khi vuốt. 0 = kêu MỖI lần cào (có thể chồng âm khi cào nhanh); tăng lên (vd 0.05-0.1) để thưa bớt.")]
		[SerializeField]
		private float swipeMinInterval;

		private float _lastSwipeTime;

		[SerializeField]
		private MMF_Player bgmFB;

		[SerializeField]
		private MMF_Player winFB;

		[SerializeField]
		private MMF_Player loseFB;

		[SerializeField]
		private MMF_Player btnClickFB;

		[SerializeField]
		private MMF_Player coinWinFB;

		[SerializeField]
		private MMF_Player sandSwipeFB;

		[SerializeField]
		private MMF_Player fillBoxFB;

		[SerializeField]
		private MMF_Player fullBoxFB;

		[SerializeField]
		private MMF_Player iceCrackFB;

		[SerializeField]
		private MMF_Player iceBreakingFB;

		[SerializeField]
		private MMF_Player useBoosterFB;

		[SerializeField]
		private AudioSource catbaySource;

		[SerializeField]
		private AudioSource sandDropSource;

		private void OnMusicSettingChange(ref AEventManager.OnMusicSettingChange eventData)
		{
		}

		private void OnSfxSettingChange(ref AEventManager.OnSfxSettingChange eventData)
		{
		}

		private void OnSceneStartPlay(ref AEventManager.OnSceneStartPlay eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnLevelLoseCondition(ref AEventManager.OnLevelLoseCondition eventData)
		{
		}

		private void OnPanelStartClose(ref AEventManager.OnPanelStartClose eventData)
		{
		}

		private void OnButtonTryClicked(ref AEventManager.OnButtonTryClicked eventData)
		{
		}

		private void OnReceiveFinishLevelCoin(ref AEventManager.OnReceiveFinishLevelCoin eventData)
		{
		}

		private void OnSandSwipeStamp(ref AEventManager.OnSandSwipeStamp eventData)
		{
		}

		private void OnJarFilled(ref AEventManager.OnJarFilled eventData)
		{
		}

		private void OnJarSealed(ref AEventManager.OnJarSealed eventData)
		{
		}

		private void OnIceShapeBroke(ref AEventManager.OnIceShapeBroke eventData)
		{
		}

		private void OnTryExecuteBooster(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void OnBeltFlowChanged(ref AEventManager.OnBeltFlowChanged eventData)
		{
		}

		private void OnSandDropChanged(ref AEventManager.OnSandDropChanged eventData)
		{
		}

		private void PlayBGM()
		{
		}

		private void StopBGM()
		{
		}

		private void PlayWin()
		{
		}

		private void PlayLose()
		{
		}

		private void PlayButtonTryClicked()
		{
		}

		public override void PlayUIClick()
		{
		}

		private void PlayCoinWinSound()
		{
		}

		private void PlaySwipe()
		{
		}

		private void PlayFillBox()
		{
		}

		private void PlayFullBox()
		{
		}

		private void PlayIceCrack()
		{
		}

		private void PlayIceBreaking()
		{
		}

		private void PlayUseBooster()
		{
		}

		private void SetCatbayLoop(bool on)
		{
		}

		private void SetSandDropLoop(bool on)
		{
		}

		private void StopFlowLoops()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
