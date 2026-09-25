using Animancer;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class IceBlocker_Anid : AIceBlocker
	{
		[Tooltip("Sàn thời gian giữ trước khi trả pool khi hình VỠ (giây) — dùng khi KHÔNG có breakClip; có clip thì lấy độ dài clip nếu dài hơn.")]
		[SerializeField]
		[Min(0f)]
		private float breakDuration;

		[Tooltip("Biên độ punch scale mỗi lần 1 jar clear mà hình chưa tan (giật nhẹ báo tiến độ).")]
		[SerializeField]
		[Min(0f)]
		private float countPunchStrength;

		[Tooltip("Thời gian punch scale (giây).")]
		[SerializeField]
		[Min(0f)]
		private float countPunchDuration;

		[Tooltip("Animancer chơi clip VỠ khi hình vỡ (bước cuối). Bỏ trống -> chỉ ẩn model, không có anim vỡ.")]
		[SerializeField]
		private AnimancerComponent breakAnimancer;

		[Tooltip("Clip animation VỠ (shatter) — chơi trên breakAnimancer. Bỏ trống -> despawn theo breakDuration.")]
		[SerializeField]
		private AnimationClip breakClip;

		[Tooltip("Mesh/model thân băng — VỠ = SetActive(false) tức thì (particle che chỗ). Setup bật lại cho pool-reuse.")]
		[SerializeField]
		private GameObject model;

		public TMP_Text stepDoneText;

		public Transform scaleObj;

		private int _totalSteps;

		private int _stepDone;

		private Vector3 _baseScale;

		private float _clipWorldY;

		private bool _shattered;

		private Vector3 _baseTextScale;

		private bool _baseTextScaleCached;

		private static readonly int ClipWorldYId;

		private Renderer[] _clipRenderers;

		private MaterialPropertyBlock _mpb;

		public Transform breakedTarget;

		public override Vector3 BreakedTargetPosition => default;

		public override void SetClipWorldY(float worldY)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override void ApplyBaseScale(Vector3 localScale)
		{
		}

		public override void Setup(int totalStepToBreak)
		{
		}

		public override bool PlayBroke()
		{
			return false;
		}

		private void RefreshStepText()
		{
		}

		private void ApplyTextScale()
		{
		}

		private void UpdateStepTextVisibility()
		{
		}

		private void PlayPunch()
		{
		}

		private void PlayShatter()
		{
		}

		private float ResolveDespawnDelay()
		{
			return 0f;
		}
	}
}
