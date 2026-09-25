using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class BackGroundFadeBooster : ABackGroundFadeBooster
	{
		[SerializeField]
		private SpriteRenderer[] sprites;

		[SerializeField]
		private float alpha;

		[SerializeField]
		private float duration;

		private readonly Color _color;

		public override void Show(Action onDone)
		{
		}

		public override void Hide()
		{
		}
	}
}
