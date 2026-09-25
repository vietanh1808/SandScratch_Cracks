using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

public abstract class AIceBreaker : JMonoBehaviour
{
	public abstract void MoveToTarget(Vector3 worldTarget, Action onArrive);

	public abstract void MoveBeizerToTarget(Vector3 worldTarget, Action onArrive);
}
