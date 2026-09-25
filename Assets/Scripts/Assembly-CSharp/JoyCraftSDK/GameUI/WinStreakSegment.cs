using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class WinStreakSegment : JMonoBehaviour
	{
		[SerializeField]
		private Image fill;

		[SerializeField]
		private Image tierMarker;

		[SerializeField]
		private Sprite markerLocked;

		[SerializeField]
		private Sprite markerReached;

		public float Fill
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Tween DOFill(float target, float duration)
		{
			return null;
		}

		public void SetTier(bool hasTier, bool reached)
		{
		}
	}
}
