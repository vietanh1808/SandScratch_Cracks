using JoyCraftSDK.Game;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupLoseCountdown : JUIPanel
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private TMP_Text label;

		[SerializeField]
		private MMF_Player tickFeedback;

		[Tooltip("Format text — {0} = số giây nguyên còn lại (làm tròn LÊN).")]
		[SerializeField]
		private string format;

		[Tooltip("Màu nền (lúc còn nhiều giây).")]
		[SerializeField]
		private Color normalColor;

		[Tooltip("Màu ở đỉnh nháy cảnh báo (nháy suốt vì panel này = tình huống nguy hiểm).")]
		[SerializeField]
		private Color warnColor;

		[Tooltip("Số nhịp nháy mỗi giây.")]
		[SerializeField]
		private float blinkPerSecond;

		[Tooltip("Biên phồng scale ở đỉnh nháy (0.12 = to thêm 12%). 0 = tắt phồng, chỉ nháy màu.")]
		[SerializeField]
		private float pulseScalePunch;

		[Tooltip("Hoãn (giây) trước khi bắn punch số ĐẦU sau khi popup mở. 0 = bounce ngay frame đầu. Tăng nếu muốn số hiện 1 nhịp rồi mới bounce.")]
		[SerializeField]
		private float openPunchDelay;

		[SerializeField]
		private Image dangerVignette;

		[Tooltip("Số nhịp thở của viền đỏ mỗi giây.")]
		[SerializeField]
		private float vignettePulsePerSecond;

		[Tooltip("Alpha đỉnh của viền đỏ (0..1).")]
		[SerializeField]
		private float vignetteMaxAlpha;

		private MaxGrainGate _gate;

		private int _lastShown;

		private Vector3 _baseScale;

		private bool _baseScaleCached;

		private float _vignetteStartTime;

		private float _pendingFirstPunchAt;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void Bind(MaxGrainGate gate)
		{
		}

		protected override void Init()
		{
		}

		protected override void RegisterEvent()
		{
		}

		private void ForceClickThrough()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		private void Tick(ref AEventManager.OnUpdate _)
		{
		}

		private void PulseVignette()
		{
		}

		private void RefreshOnce(bool suppressFeedback)
		{
		}

		private void PlayTick()
		{
		}

		private void ApplyBlink()
		{
		}

		private void CacheBaseScale()
		{
		}
	}
}
