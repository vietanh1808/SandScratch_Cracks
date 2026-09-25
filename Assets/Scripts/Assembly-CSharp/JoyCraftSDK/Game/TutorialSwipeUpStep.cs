using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class TutorialSwipeUpStep : JMonoBehaviour, IStep, IStepEvent
	{
		private const string GroupOverlay = "Overlay";

		private const string GroupHand = "Hand";

		private const string GroupHint = "Hint";

		private const string GroupComplete = "Complete";

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

		[Tooltip("Thời gian 1 lượt tay quẹt từ dưới lên (giây); animation tự lặp.")]
		[SerializeField]
		private float handSwipeTime;

		[Tooltip("Tay XUẤT PHÁT thấp hơn mép ĐÁY tranh bao nhiêu, theo tỉ lệ chiều cao tranh (nhấn ý 'bắt đầu từ dưới').")]
		[Range(0f, 0.5f)]
		[SerializeField]
		private float handStartBelowFraction;

		[Tooltip("Tay đi lên tới đâu, tính từ mép ĐÁY tranh theo tỉ lệ chiều cao tranh (0.75 = 3/4 tranh).")]
		[Range(0.1f, 1f)]
		[SerializeField]
		private float handTravelFraction;

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

		[Tooltip("Quãng ĐI LÊN cần đạt trong 1 nét (tỉ lệ chiều cao tranh TRÊN MÀN HÌNH) thì mới tính là 'vuốt lên'.")]
		[Range(0.05f, 1f)]
		[SerializeField]
		private float requiredUpFraction;

		[Tooltip("Bắt quãng DỌC phải trội hơn quãng NGANG (chống tính nhầm nét vuốt xiên/ngang).")]
		[SerializeField]
		private bool requireVerticalDominance;

		[Tooltip("Dọc phải >= ngang × hệ số này. 1 = dọc ăn đứt ngang; hạ xuống cho dễ.")]
		[Range(0.3f, 3f)]
		[SerializeField]
		private float verticalDominanceRatio;

		[Tooltip("Chống kẹt: sau chừng này giây, BẤT KỲ nét cào nào cũng hoàn thành step (0 = tắt).")]
		[SerializeField]
		private float giveUpSeconds;

		private PictureColliderBuilder _pictureBuilder;

		private bool _handBaked;

		private Vector3 _handBakedCenter;

		private Vector2 _handBakedSize;

		private bool _layoutWarned;

		private float _layoutWaitSeconds;

		private float _elapsedSeconds;

		private float _pictureScreenHeight;

		private bool _tracking;

		private bool _strokeCarved;

		private Vector2 _strokeAnchor;

		private float _strokeMaxDx;

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

		private void GetSandSwipeCarved(ref AEventManager.OnSandSwipeCarved eventData)
		{
		}

		private void GetUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void TrackGesture()
		{
		}

		private float RequiredUpPixels()
		{
			return 0f;
		}

		private void ResetStroke()
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
