using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "SafeAreaData", menuName = "GameSDK/SafeAreaData")]
	public class SafeAreaData : JScriptableObject
	{
		[Header("Viewport Coordinates (0-1)")]
		[SerializeField]
		private Vector2 viewportBottomLeft;

		[SerializeField]
		private Vector2 viewportTopRight;

		public Vector2 ViewportBottomLeft => default;

		public Vector2 ViewportTopRight => default;

		public float Left => 0f;

		public float Right => 0f;

		public float Bottom => 0f;

		public float Top => 0f;

		public float ViewportWidth => 0f;

		public float ViewportHeight => 0f;

		private string ValidationStatus => null;

		private Vector2 Size => default;

		public bool IsValid()
		{
			return false;
		}

		private bool IsInRange01(Vector2 v)
		{
			return false;
		}
	}
}
