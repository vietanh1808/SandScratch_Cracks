using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnTryRetry : JButton
	{
		[SerializeField]
		private Image btnImg;

		[SerializeField]
		private Sprite normalSr;

		[SerializeField]
		private Sprite hardSr;

		[SerializeField]
		private Sprite veryHardSr;

		protected override void OnClick()
		{
		}

		public override void Awake()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnValidate()
		{
		}

		private void UpdateImg()
		{
		}
	}
}
