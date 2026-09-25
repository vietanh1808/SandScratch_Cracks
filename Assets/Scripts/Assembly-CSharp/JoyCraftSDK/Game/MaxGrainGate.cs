using System;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class MaxGrainGate : JMonoBehaviour
	{
		[Tooltip("Bundle config sand-flow — nguồn ngưỡng hysteresis belt-full + timeout thua (GrainTuningConfig.GrainBeltFullEntry/Exit/TimeoutSeconds). Bỏ trống -> gate NGỦ (không đóng cửa, không boost, không thua).")]
		[SerializeField]
		private SandFlowConfig sandFlowConfig;

		private ISandFlowBackend _backend;

		private bool _active;

		private bool _beltFullActive;

		private bool _beltFull;

		private bool _lostRaised;

		private bool _preLostRaised;

		private float _beltFullElapsed;

		private bool _boosterPending;

		[CompilerGenerated]
		private Action<bool> m_OnBeltFullChanged;

		private GrainTuningConfig TuningConfig => null;

		public bool BeltFull => false;

		public bool BeltFullActive => false;

		public float RemainingLoseSeconds => 0f;

		public bool IsLoseCountdownActive => false;

		public event Action<bool> OnBeltFullChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Begin(ISandFlowBackend backend)
		{
		}

		public void End()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnTryExecuteBooster(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void OnRevokeBooster(ref AEventManager.OnRevokeBooster eventData)
		{
		}

		private void OnCompleteBoosterExecution(ref AEventManager.OnCompleteBoosterExecution eventData)
		{
		}

		private void Tick(ref AEventManager.OnUpdate _)
		{
		}

		private void UpdateHysteresis(float fill)
		{
		}

		private void CheckTimeout()
		{
		}

		private void SetBeltFull(bool full)
		{
		}
	}
}
