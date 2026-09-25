using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JPageEnterAnim : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private RectTransform target;

		[SerializeField]
		private float slideDistance;

		[SerializeField]
		private float duration;

		[SerializeField]
		private float delay;

		[SerializeField]
		private EasingType easing;

		[SerializeField]
		private bool unscaledTime;

		private Vector2 _homePos;

		private bool _parked;

		private Vector2 ParkedPos => default;

		public override void Awake()
		{
		}

		public void PlayEnter()
		{
		}

		public void SnapHome()
		{
		}

		public void Park()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
