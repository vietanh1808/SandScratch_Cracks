using System;
using DG.Tweening;
using UnityEngine;

public class IceBreaker : AIceBreaker
{
	[Tooltip("Thời gian bay từ jar tới IceBlocker (giây).")]
	[SerializeField]
	[Min(0f)]
	private float moveDuration;

	[Tooltip("Ease đường bay (bay thẳng khi arcHeight = 0).")]
	[SerializeField]
	private Ease moveEase;

	[Tooltip("Độ cao vòng cung ở điểm giữa đường bay (world). 0 = bay thẳng.")]
	[SerializeField]
	[Min(0f)]
	private float arcHeight;

	[Tooltip("Độ cong đường Bezier bậc 2 (world): control point = trung điểm + up * giá trị này. 0 = bay thẳng.")]
	[SerializeField]
	private float bezierCurveHeight;

	public override void MoveToTarget(Vector3 worldTarget, Action onArrive)
	{
	}

	public override void MoveBeizerToTarget(Vector3 worldTarget, Action onArrive)
	{
	}

	private Tween BuildArcTween(Transform t, Vector3 target)
	{
		return null;
	}
}
