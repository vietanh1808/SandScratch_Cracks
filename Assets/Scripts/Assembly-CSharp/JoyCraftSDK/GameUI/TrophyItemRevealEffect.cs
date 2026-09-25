using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TrophyItemRevealEffect : JMonoBehaviour
	{
		private const string Group_References = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private Image _iconTemplate;

		[SerializeField]
		private Sprite _fallbackSprite;

		[SerializeField]
		private float _heroScale;

		[SerializeField]
		private float _heroHoldTime;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private float _flyCurveOffset;

		[SerializeField]
		private float _landScale;

		[SerializeField]
		private float _punchStrength;

		[SerializeField]
		private float _punchDuration;

		[SerializeField]
		private float _appearDuration;

		private Image _spawnedIcon;

		private bool _isPlaying;

		private bool _finished;

		public void Play(Sprite sprite, Vector3 fromPosition, Transform targetSlot, Action onComplete)
		{
		}

		private void PunchTarget(Transform targetSlot)
		{
		}

		protected override void OnDisable()
		{
		}

		private void Finish(Action onComplete)
		{
		}
	}
}
