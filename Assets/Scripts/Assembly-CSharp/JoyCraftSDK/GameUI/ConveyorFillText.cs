using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ConveyorFillText : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private TMP_Text label;

		[Tooltip("Format text — {0} = phần trăm nguyên (0..100).")]
		[SerializeField]
		private string format;

		[Tooltip("Tốc độ đếm (%/giây). Số lăn ĐỀU tới giá trị thật rồi dừng (MoveTowards, không có đuôi ease-out ì). Cao = đuổi kịp nhanh.")]
		[SerializeField]
		private float countSpeed;

		[Tooltip("Từ ngưỡng % này trở lên (mặc định 90) -> bật hiệu ứng cảnh báo: nháy đỏ + phồng nhẹ.")]
		[SerializeField]
		private int warnThresholdPercent;

		[Tooltip("Màu bình thường (dưới ngưỡng cảnh báo).")]
		[SerializeField]
		private Color normalColor;

		[Tooltip("Màu ở đỉnh nháy trong vùng >= ngưỡng cảnh báo.")]
		[SerializeField]
		private Color warnColor;

		[Tooltip("Số lần nháy mỗi giây trong vùng cảnh báo.")]
		[SerializeField]
		private float blinkPerSecond;

		[Tooltip("Biên phồng scale ở đỉnh nháy (0.12 = to thêm 12%). 0 = tắt phồng, chỉ nháy màu.")]
		[SerializeField]
		private float warnScalePunch;

		private GrainFlowBackend _backend;

		private float _display;

		private int _lastShown;

		private Vector3 _baseScale;

		private bool _baseScaleCached;

		private bool _inWarn;

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

		private void ApplyWarnEffect(int shown, bool textChanged)
		{
		}

		private void SetVertexColor(Color32 c)
		{
		}

		private void CacheBaseScale()
		{
		}
	}
}
