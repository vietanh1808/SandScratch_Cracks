using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class FrozenShapeDef : JBase
	{
		private const string Group_Identity = "Định danh";

		private const string Group_Size = "Kích cỡ (pixel tranh)";

		[Tooltip("ID BỀN do thư viện cấp (FL7) — KHÔNG sửa tay, KHÔNG tái dùng. 0 = CHƯA cấp (shape thêm sai đường, xem FrozenShapeLibrary).")]
		[SerializeField]
		private int id;

		[SerializeField]
		private FrozenShapeKind kind;

		[Tooltip("Prefab thân băng — CHƯA tiêu thụ (2026-07-17: băng thể hiện bằng XÁM MÀU vùng bị khoá, prefab làm sau). Để trống được.")]
		[SerializeField]
		private GameObject prefab;

		[Tooltip("Bán kính (đơn vị: pixel tranh MECHANIC). Chỉ dùng khi kind = Circle.")]
		[SerializeField]
		[Min(0f)]
		private float radiusPx;

		[Tooltip("Bề RỘNG (pixel tranh MECHANIC). Chỉ dùng khi kind = Rect.")]
		[SerializeField]
		[Min(0f)]
		private float widthPx;

		[Tooltip("Chiều CAO (pixel tranh MECHANIC). Chỉ dùng khi kind = Rect.")]
		[SerializeField]
		[Min(0f)]
		private float heightPx;

		public int Id => 0;

		public FrozenShapeKind Kind => FrozenShapeKind.Circle;

		public GameObject Prefab => null;

		public float RadiusPx => 0f;

		public float WidthPx => 0f;

		public float HeightPx => 0f;

		public FrozenShapeDef()
		{
		}

		public FrozenShapeDef(int id, FrozenShapeKind kind)
		{
		}

		public void SetKind(FrozenShapeKind value)
		{
		}

		public void SetRadiusPx(float value)
		{
		}

		public void SetSizePx(float width, float height)
		{
		}

		public void SetPrefab(GameObject value)
		{
		}

		public Vector2 HalfExtentsPx(float scale)
		{
			return default;
		}
	}
}
