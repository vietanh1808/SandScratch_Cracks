using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "ObiFlowLayoutConfig", menuName = "GameSDK/ObiFlowLayoutConfig")]
	public class ObiFlowLayoutConfig : JScriptableObject
	{
		[Tooltip("Vị trí GO 'ObiFlow' (neo dưới flowRoot). Căn cả rig so với tranh/camera.")]
		[SerializeField]
		private Vector3 rigPosition;

		[Tooltip("Xoay GO 'ObiFlow' (euler độ). 2D -> chỉ trục Z có nghĩa; X/Y collider không theo.")]
		[SerializeField]
		private Vector3 rigEuler;

		[Tooltip("PHÓNG TO hình học rig (đồng đều): phễu/stadium/chute/khung/vortex + collider ×scale, CĂN vị trí theo. KHÔNG scale solver -> gravity/EmitSpeed/particleSize giữ đơn vị THẬT. 1 = giữ nguyên.")]
		[SerializeField]
		[Min(0.0001f)]
		private float rigGeometryScale;

		[Tooltip("localPosition SandQuadRoot — căn tranh khớp miệng phễu.")]
		[SerializeField]
		private Vector3 quadPosition;

		[Tooltip("localRotation SandQuadRoot (euler độ). 2D -> chỉ trục Z có nghĩa.")]
		[SerializeField]
		private Vector3 quadEuler;

		[Tooltip("localScale SandQuadRoot — phóng to tranh + collider đặc (transform, KHÔNG phải solver nên không méo physics).")]
		[SerializeField]
		private Vector3 quadScale;

		[Tooltip("Vẽ gizmo viền collider rig (GrainFlowBackend) + collider đặc tranh (PictureColliderBuilder) trong Scene view.")]
		[SerializeField]
		private bool drawGizmos;

		[Tooltip("Màu gizmo viền rig (phễu/stadium/chute/khung/vortex).")]
		[SerializeField]
		private Color rigGizmoColor;

		[Tooltip("Màu gizmo collider ĐẶC của tranh.")]
		[SerializeField]
		private Color pictureGizmoColor;

		public float RigGeometryScale => 0f;

		public bool DrawGizmos => false;

		public Color RigGizmoColor => default;

		public Color PictureGizmoColor => default;

		public void GetRigTransform(out Vector3 position, out Quaternion rotation)
		{
			position = default;
			rotation = default;
		}

		public void GetQuadLocal(out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
			position = default;
			rotation = default;
			scale = default;
		}
	}
}
