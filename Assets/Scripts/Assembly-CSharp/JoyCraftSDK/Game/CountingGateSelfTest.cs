using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class CountingGateSelfTest : JMonoBehaviour
	{
		[Tooltip("FAKE backend nguồn FillRatio + tự raise OnPixelArrivedAtJar. Bắt buộc.")]
		[SerializeField]
		private FakeSandFlowBackend fakeBackend;

		[Tooltip("Gate hysteresis + lose-timer cần test. Bắt buộc.")]
		[SerializeField]
		private MaxGrainGate gate;

		[Tooltip("Optional: bind để test route +count vào jar (D3). Bỏ trống -> chỉ test gate/lose-timer.")]
		[SerializeField]
		private ColorJarController colorJarController;

		private int _loseCount;

		private bool _wired;

		public void Setup()
		{
		}

		private void HandleBeltFullChanged(bool full)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void HandleLevelFinished(ref AEventManager.OnLevelFinished e)
		{
		}

		private void OnGUI()
		{
		}
	}
}
