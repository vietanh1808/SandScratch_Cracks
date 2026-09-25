using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Gameplay
{
	public abstract class AGameplayController : JMonoBehaviour
	{
		[Tooltip("Hệ số nhân tốc độ khi bật speed-up (2 = x2). Đọc lúc SetSpeedUp -> đổi ở Inspector là ăn ngay.")]
		[SerializeField]
		[Min(0.1f)]
		private float speedUpRate;

		private bool speedUpBillable;

		private float pendingBudgetSeconds;

		public bool IsSpeedUp { get; private set; }

		public float SpeedUpRate => 0f;

		public int SpeedUpSecondsLeft => 0;

		public bool HasSpeedUpTime => false;

		public bool IsSpeedUpBillable => false;

		public bool TrySetSpeedUp()
		{
			return false;
		}

		public void ForceSpeedUp()
		{
		}

		private void ApplySpeedUp(bool billable)
		{
		}

		public void SetNormalSpeed()
		{
		}

		public bool ToggleSpeedUp()
		{
			return false;
		}

		public void AddSpeedUpTime(int seconds)
		{
		}

		private void TickSpeedUpBudget(ref AEventManager.OnUpdate eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public abstract void RaiseLevelFinished(LevelFinishReason reason, LevelFailReason failReason);

		public abstract void TryLoadCurrentLevel(Action IfSuccess, LevelPlayType playType);

		public abstract void CloseScreenLose();

		public abstract void TryRetryMidGame();

		public abstract void TryQuitLevel();

		public abstract void QuitLevel();

		public abstract void TryPlayOn();

		public virtual void WinLevelFromPurchase()
		{
		}

		public virtual void PlayOnFromAds()
		{
		}

		public virtual void PlayOnFromPurchase()
		{
		}

		public abstract void SkipLevel();

		public abstract void CheckLoseCondition();
	}
}
