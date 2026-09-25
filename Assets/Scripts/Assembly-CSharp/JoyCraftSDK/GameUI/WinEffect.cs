using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class WinEffect : AWinEffect
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private List<RectTransform> iconList;

		[SerializeField]
		private Transform targetPoint;

		[SerializeField]
		private Vector2 startPoint;

		[SerializeField]
		private float minDist;

		[SerializeField]
		private float maxDist;

		[SerializeField]
		private float scatterDuration;

		[SerializeField]
		private float gatherDuration;

		[SerializeField]
		private float delayBetweenIcons;

		private Vector3 targetPosition;

		public override void Show(Action callback = null)
		{
		}

		public override void Show(Vector3 endPosition, Action callback = null)
		{
		}

		public override void Show(Transform target, Action callback = null)
		{
		}

		private Vector2 GetRandomScatterPoint()
		{
			return default;
		}
	}
}
