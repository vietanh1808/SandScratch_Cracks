using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class FrozenPlacementData : JBase
	{
		private const string Group_Shape = "Hình";

		private const string Group_Transform = "Đặt trên tranh (picture-space)";

		[Tooltip("Trỏ FrozenShapeDef.Id trong thư viện (FL7 — id BỀN, KHÔNG phải index list). 0 = chưa gán -> ref chết.")]
		[SerializeField]
		private int shapeId;

		[Tooltip("Số colorJar phải clear để hình NÀY tan (FL4). Trừ khi hình đang LỘ trong cửa sổ (FL5).")]
		[SerializeField]
		[Min(0f)]
		private int count;

		[Tooltip("Tâm hình theo trục X (pixel tranh, float).")]
		[SerializeField]
		private float centerX;

		[Tooltip("Tâm hình theo trục Y (pixel tranh, float). y = 0 là ĐỈNH ảnh.")]
		[SerializeField]
		private float centerY;

		[SerializeField]
		private float rotationDeg;

		[Tooltip("Tinh chỉnh cỡ per-level. Kích cỡ HIỆU LỰC = (cỡ trong thư viện) × giá trị này.")]
		[SerializeField]
		[Min(0.01f)]
		private float scale;

		public int ShapeId => 0;

		public int Count => 0;

		public float CenterX => 0f;

		public float CenterY => 0f;

		public float RotationDeg => 0f;

		public float Scale => 0f;

		public Vector2 Center => default;

		public FrozenPlacementData()
		{
		}

		public FrozenPlacementData(int shapeId, float centerX, float centerY, int count)
		{
		}

		public void SetCenter(float x, float y)
		{
		}

		public void SetRotationDeg(float degrees)
		{
		}

		public void SetScale(float value)
		{
		}

		public void SetCount(int value)
		{
		}
	}
}
