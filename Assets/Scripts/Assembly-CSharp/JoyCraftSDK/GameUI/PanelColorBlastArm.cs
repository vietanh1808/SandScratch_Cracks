using JoyCraftSDK.Game;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PanelColorBlastArm : JUIPanel
	{
		private const string Group_Cutout = "Cutout (4 tấm tối chừa vùng tranh)";

		private const string Group_Hint = "Hint";

		[Tooltip("4 tấm tối phủ quanh vùng tranh; lỗ khoét = khoảng hở giữa chúng. Prefab chỉ cần gán Image màu tối (KHÔNG cần sprite — Image không sprite đã là mảng màu đặc), anchor do code set.")]
		[SerializeField]
		private RectTransform overlayTop;

		[SerializeField]
		private RectTransform overlayBottom;

		[SerializeField]
		private RectTransform overlayLeft;

		[SerializeField]
		private RectTransform overlayRight;

		[Tooltip("Nới lỗ khoét ra ngoài mép tranh, theo tỉ lệ viewport (0.01 ≈ 1% màn hình).")]
		[SerializeField]
		private float cutoutPaddingViewport;

		[Tooltip("Text hướng dẫn. Trống -> bỏ qua.")]
		[SerializeField]
		private TMP_Text hintText;

		[Tooltip("Nội dung text. Để TRỐNG = giữ nguyên chữ đã gõ sẵn trên prefab (không ghi đè).")]
		[SerializeField]
		[TextArea]
		private string hintMessage;

		private PictureColliderBuilder _pictureCarve;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void SetPictureSource(PictureColliderBuilder pictureCarve)
		{
		}

		protected override void Init()
		{
		}

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		private void GetUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void ForceClickThrough()
		{
		}

		private bool TryLayoutCutout()
		{
			return false;
		}

		private void CollapseCutout()
		{
		}

		private static void SetAnchors(RectTransform rect, Vector2 anchorMin, Vector2 anchorMax)
		{
		}
	}
}
