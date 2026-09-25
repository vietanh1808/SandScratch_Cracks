using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Image))]
	public class SafeAreaVisualizer : JMonoBehaviour
	{
		[Header("Data")]
		[SerializeField]
		private SafeAreaData safeAreaData;

		[Header("Visual Settings")]
		[SerializeField]
		private Color borderColor;

		[SerializeField]
		private bool showInPlayMode;

		[SerializeField]
		private bool showInEditMode;

		private RectTransform _rectTransform;

		private Image _image;

		private Canvas _parentCanvas;

		private Vector2 ViewportBottomLeft => default;

		private Vector2 ViewportTopRight => default;

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateVisual()
		{
		}
	}
}
