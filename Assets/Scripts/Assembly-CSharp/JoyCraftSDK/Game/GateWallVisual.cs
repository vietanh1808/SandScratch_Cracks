using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class GateWallVisual : JMonoBehaviour
	{
		[Tooltip("Phần cửa DI CHUYỂN. Bỏ trống -> dùng chính transform của GO này.")]
		[SerializeField]
		private Transform door;

		[Tooltip("localPosition khi cửa MỞ hẳn (DoorOpenness = 0). Dùng nút Capture Open để lấy từ vị trí hiện tại.")]
		[SerializeField]
		private Vector3 openLocalPosition;

		[Tooltip("localPosition khi cửa ĐÓNG kín (DoorOpenness = 1). Dùng nút Capture Closed để lấy từ vị trí hiện tại.")]
		[SerializeField]
		private Vector3 closedLocalPosition;

		private GrainFlowBackend _backend;

		private float _lastApplied;

		private Transform Door => null;

		public void Init(GrainFlowBackend backend)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void Tick(ref AEventManager.OnUpdate _)
		{
		}

		private void Apply(float openness)
		{
		}

		private void CaptureOpen()
		{
		}

		private void CaptureClosed()
		{
		}

		private void PreviewOpen()
		{
		}

		private void PreviewClosed()
		{
		}
	}
}
