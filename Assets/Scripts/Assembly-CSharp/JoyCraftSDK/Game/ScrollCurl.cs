using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class ScrollCurl : AScrollCurl
	{
		private const string Group_Pose = "Pose (chỉnh tay sau khi update asset)";

		private const string Group_Shape = "Shape";

		private const string Group_Render = "Render";

		[Tooltip("Offset của dải so với gốc prefab (gốc prefab đã được đặt ở MÉP TRÊN cửa sổ cột). Z = độ sâu — knob để đẩy dải ra TRƯỚC hay ra SAU art rèm/khung.")]
		[SerializeField]
		private Vector3 localOffset;

		[Tooltip("Euler xoay thêm của dải (so với hướng quad tranh của cột).")]
		[SerializeField]
		private Vector3 localEuler;

		[Tooltip("Bán kính cuộn (world). 0 = dải PHẲNG (không uốn). Càng nhỏ càng cuộn gắt.")]
		[SerializeField]
		private float curlRadius;

		[Tooltip("Chặn trên góc cuộn (độ). Dải dài + bán kính nhỏ sẽ tự NỚI bán kính để không vượt góc này (tránh cuộn chồng lên chính nó).")]
		[SerializeField]
		private float maxArcDegrees;

		[Tooltip("Số đoạn chia dọc dải — càng nhiều càng mượt đường cong.")]
		[SerializeField]
		private int subdivisions;

		[Tooltip("Sinh cả mặt sau (2 lớp tam giác ngược chiều) — phần dải vòng qua đỉnh trục cuộn quay mặt ra SAU, không có cái này thì backface-cull ăn mất.")]
		[SerializeField]
		private bool doubleSided;

		[Tooltip("Material vẽ dải. PHẢI là shader có _MainTex + hỗ trợ _MainTex_ST (dùng CÙNG material với SandSurface của tranh là an toàn nhất) — cửa sổ UV đẩy qua _MainTex_ST. Bỏ trống -> Unlit/Transparent.")]
		[SerializeField]
		private Material curlMaterial;

		[Tooltip("Lật ảnh theo chiều NGANG (hiệu ứng nhìn mặt sau tờ giấy).")]
		[SerializeField]
		private bool mirrorU;

		[Tooltip("Lật ảnh theo chiều DỌC (hiệu ứng cuộn ngược vòng qua trục).")]
		[SerializeField]
		private bool mirrorV;

		private static readonly int MainTexStId;

		private MeshRenderer _stripRenderer;

		private Mesh _mesh;

		private Material _materialInstance;

		private MaterialPropertyBlock _mpb;

		private float _v0;

		private float _v1;

		public override void Setup(float bandWorldHeight, float columnWorldWidth, Texture2D texture)
		{
		}

		public override void SetUvWindow(float v0, float v1)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		private void EnsureStrip()
		{
		}

		private static Material DefaultMaterial()
		{
			return null;
		}

		private void BuildMesh(float bandWorldHeight, float columnWorldWidth)
		{
		}

		private void ApplyUv()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
