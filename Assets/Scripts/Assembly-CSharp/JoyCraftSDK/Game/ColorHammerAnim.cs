using System;
using Animancer;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[RequireComponent(typeof(AnimancerComponent))]
	public class ColorHammerAnim : AColorHammerAnim
	{
		private const string Group_Refs = "References";

		private const string Group_Clips = "Clips";

		private const string Group_Fx = "Hit VFX (tuỳ chọn)";

		[SerializeField]
		private AnimancerComponent animancer;

		[Tooltip("Búa XUẤT HIỆN — chạy tại chỗ đỗ (hidePos), trước khi bay tới điểm chạm.")]
		[SerializeField]
		private AnimationClip showClip;

		[Tooltip("Búa NỆN xuống — chạy khi búa ĐÃ tới điểm chạm.")]
		[SerializeField]
		private AnimationClip hitClip;

		[Tooltip("Búa BIẾN MẤT — chạy xong thì controller đỗ búa lại hidePos.")]
		[SerializeField]
		private AnimationClip hideClip;

		[Tooltip("Feedback VFX nện — bắn ngay đầu clip HIT. Canh trễ cho khớp frame búa CHẠM mặt tranh bằng Initial Delay của từng feedback bên trong MMF_Player. TRỐNG = không có VFX.")]
		[SerializeField]
		private MMF_Player hitFb;

		[SerializeField]
		private MMF_Player hitVFX_1;

		private void OnValidate()
		{
		}

		public void PlayShow()
		{
		}

		public override void PlayShow(Action onComplete)
		{
		}

		public void PlayHit()
		{
		}

		public override void PlayHit(Action onComplete)
		{
		}

		public void PlayHide()
		{
		}

		public override void PlayHide(Action onComplete)
		{
		}

		private void PlayOneShot(AnimationClip clip, string clipFieldName, Action onComplete)
		{
		}
	}
}
