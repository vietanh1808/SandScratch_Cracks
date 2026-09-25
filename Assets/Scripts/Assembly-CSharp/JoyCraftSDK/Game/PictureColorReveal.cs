using System.Collections.Generic;
using JoyCraftSDK.Game.SandSimulation;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class PictureColorReveal : JMonoBehaviour
	{
		private struct RevealCell
		{
			public int x;

			public int y;

			public Color32 color;

			public float dist;
		}

		[Header("Refs")]
		[Tooltip("Tranh nằm trên field này (Obi mode). Đọc/ghi màu pixel qua GetColor/SetColor.")]
		[SerializeField]
		private SandField sandField;

		[Tooltip("Optional: khoá swipe trong lúc lộ màu, mở khi xong. Bỏ trống -> không gate (swipe ngay).")]
		[SerializeField]
		private SandSwipeController swipeController;

		[Header("Reveal")]
		[Tooltip("Thời gian (giây) để vòng tròn màu lan từ tâm phủ hết tranh.")]
		[SerializeField]
		[Min(0.01f)]
		private float revealDuration;

		[Tooltip("Giữ tranh XÁM thêm bao lâu (giây) trước khi bắt đầu lan màu.")]
		[SerializeField]
		[Min(0f)]
		private float grayHoldDelay;

		[Tooltip("ON: tâm lan = trọng tâm các pixel CÓ MÀU (visual center của nội dung). OFF: tâm hình học của rect tranh.")]
		[SerializeField]
		private bool centerOnPaintedCentroid;

		private readonly List<RevealCell> _cells;

		private bool _running;

		private float _elapsed;

		private float _maxDist;

		private int _cursor;

		public bool IsRevealing => false;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public void Begin(RectInt pictureRect)
		{
		}

		public void StopReveal()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void FinishInternal()
		{
		}

		public static Color32 ToGray(Color32 c)
		{
			return default;
		}
	}
}
