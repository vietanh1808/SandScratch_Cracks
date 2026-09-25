using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class RewardFlyEffect : JMonoBehaviour
	{
		private const string Group_References = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private Image _iconTemplate;

		[SerializeField]
		private int _iconCount;

		[SerializeField]
		private float _scatterRadius;

		[SerializeField]
		private float _scatterJumpPower;

		[SerializeField]
		private float _scatterDuration;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private float _flyInterval;

		[SerializeField]
		private EasingType _scatterEasing;

		[SerializeField]
		private EasingType _flyEasing;

		[SerializeField]
		private float _flyJumpPower;

		[SerializeField]
		private float _spinDegrees;

		[SerializeField]
		private float _scatterScale;

		[SerializeField]
		private float _landScale;

		[SerializeField]
		private float _punchStrength;

		[SerializeField]
		private float _punchDuration;

		private readonly List<Image> _spawnedIcons;

		private bool _isPlaying;

		public void Play(Sprite sprite, Vector3 fromPosition, Transform flyTarget, Action onComplete)
		{
		}

		private void PunchFlyTarget(Transform flyTarget)
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
