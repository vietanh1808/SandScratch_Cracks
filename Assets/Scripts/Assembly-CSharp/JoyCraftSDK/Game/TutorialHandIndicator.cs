using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class TutorialHandIndicator : ATutorialHandIndicator
	{
		public Animator animator;

		[SerializeField]
		private float moveInTime;

		[SerializeField]
		private int clickCount;

		[SerializeField]
		private float extraCycleTime;

		private Sequence tween;

		private Transform followingTarget;

		private bool targetIsWordSpace;

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void PlayDragObjectAnimation(Vector3 from, Vector3 to, float playTime)
		{
		}

		public override void PlayDragObjectAnimation(List<Vector3> paths, float playTime)
		{
		}

		public override void PlayDragStrokesAnimation(List<List<Vector3>> strokes, List<float> strokeTimes)
		{
		}

		private void PlayStroke(List<List<Vector3>> strokes, List<float> strokeTimes, int index)
		{
		}

		public override void Stop()
		{
		}

		private void PlayAnimHolding(Action OnComplete)
		{
		}

		private void PlayAnimReleasing(Action OnComplete)
		{
		}

		public override void PlayClickAnimation()
		{
		}

		public override void PlayClickAnimation(Vector3 targetPos)
		{
		}

		public override void Follow(Transform target, bool targetIsWordSpace)
		{
		}

		public override void MoveInThenFollow(Transform target, bool targetIsWordSpace)
		{
		}

		public override void MoveThenClick(Transform fromButton, Vector3 worldTargetCenter)
		{
		}

		private void RunClickCycle(Vector3 startPos, Vector3 clickPos, Action onArrive)
		{
		}

		private float ClickClipLength()
		{
			return 0f;
		}

		private Vector3 GetScreenCenter()
		{
			return default;
		}

		public Vector3 GetCanvasPos(Vector3 worldPos)
		{
			return default;
		}

		public Vector3 OffsetCanvasPos(Vector3 canvasPos, Vector2 canvasOffset)
		{
			return default;
		}
	}
}
