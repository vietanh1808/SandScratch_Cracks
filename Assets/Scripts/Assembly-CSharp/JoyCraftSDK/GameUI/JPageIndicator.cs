using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JPageIndicator : APageIndicator
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private RectTransform indicator;

		[SerializeField]
		private bool followSize;

		[SerializeField]
		private Vector2 sizePadding;

		[SerializeField]
		private Vector2 positionOffset;

		private readonly List<RectTransform> anchors;

		public override void Bind(IReadOnlyList<RectTransform> newAnchors)
		{
		}

		public override void SetProgress(float pageProgress)
		{
		}
	}
}
