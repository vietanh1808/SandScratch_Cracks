using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class TutorialIceStep : JMonoBehaviour, IStep, IStepEvent
	{
		private const string GroupOverlay = "Overlay";

		private const string GroupHand = "Hand";

		private const string GroupHint = "Hint";

		[Tooltip("4 tấm đen phủ quanh vùng tranh. Code set anchor theo viewport-rect của tranh mỗi frame; cutout = khoảng hở giữa 4 tấm. Prefab chỉ cần gán Image màu đen mờ, anchor code tự lo.")]
		[SerializeField]
		private RectTransform overlayTop;

		[SerializeField]
		private RectTransform overlayBottom;

		[SerializeField]
		private RectTransform overlayLeft;

		[SerializeField]
		private RectTransform overlayRight;

		[Tooltip("Nới cutout ra ngoài mép tranh, theo tỉ lệ viewport (0.01 ≈ 1% màn hình).")]
		[SerializeField]
		private float cutoutPaddingViewport;

		[SerializeField]
		private TutorialHandIndicator handIndicator;

		[Tooltip("Thời gian 1 lượt tay quẹt ngang dọc mép đáy (giây); animation tự lặp.")]
		[SerializeField]
		private float handSwipeTime;

		[Tooltip("Tay CAO HƠN mép ĐÁY tranh bao nhiêu, theo tỉ lệ chiều cao tranh.")]
		[Range(0f, 0.3f)]
		[SerializeField]
		private float handAboveBottomFraction;

		[Tooltip("Quãng tay đi NGANG tính TỪ MÉP TRÁI tranh, so với bề ngang tranh (1 = trọn mép trái -> mép phải).")]
		[Range(0.1f, 1f)]
		[SerializeField]
		private float handTravelFraction;

		[Tooltip("Nét quẹt thứ 2 (ngang) nằm CAO HƠN nét đáy bao nhiêu, theo đơn vị canvas (khoảng cách CỐ ĐỊNH trên màn hình).")]
		[SerializeField]
		private float handSecondSwipeOffset;

		[Tooltip("Text hướng dẫn. Bỏ trống -> bỏ qua.")]
		[SerializeField]
		private TMP_Text hintText;

		[Tooltip("Nội dung text. Để TRỐNG = giữ nguyên chữ đã gõ sẵn trên prefab (không ghi đè).")]
		[SerializeField]
		[TextArea]
		private string hintMessage;

		[Tooltip("Khung chứa text — code đặt NGAY DƯỚI mép đáy board mỗi frame (tâm khung cách mép đáy cutout hintGapViewport). Bỏ trống -> text đứng yên theo prefab.")]
		[SerializeField]
		private RectTransform hintRect;

		[Tooltip("Khoảng từ mép đáy cutout tới TÂM text, theo tỉ lệ chiều cao viewport.")]
		[Range(0f, 0.3f)]
		[SerializeField]
		private float hintGapViewport;

		private PictureColliderBuilder _pictureBuilder;

		private bool _handBaked;

		private Vector3 _handBakedCenter;

		private Vector2 _handBakedSize;

		private bool _layoutWarned;

		private float _layoutWaitSeconds;

		private const float LayoutWaitWarnSeconds = 5f;

		public bool IsComplete { get; set; }

		public TutorialStep StepData { get; set; }

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Next()
		{
		}

		private void GetIceShapeBroke(ref AEventManager.OnIceShapeBroke eventData)
		{
		}

		private void GetUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private bool TryLayout()
		{
			return false;
		}

		private void LayoutHint(float uMin, float uMax, float vMin)
		{
		}

		private void PlayHand(Vector3 worldCenter, Vector2 worldSize)
		{
		}

		private void CollapseOverlay()
		{
		}

		private static void SetAnchors(RectTransform rect, Vector2 anchorMin, Vector2 anchorMax)
		{
		}
	}
}
