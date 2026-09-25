using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PulseEffect : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform visualTF;

		[SerializeField]
		private float pulseRate;

		[SerializeField]
		private float minScale;

		[SerializeField]
		private float speed;

		private Sequence pulseSeq;

		private Vector3 _baseScale;

		private bool _isBaseScaleCached;

		private float pulseDuration => 0f;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void CacheBaseScale()
		{
		}
	}
}
