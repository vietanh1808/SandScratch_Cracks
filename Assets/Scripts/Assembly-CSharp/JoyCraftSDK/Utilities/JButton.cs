using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[RequireComponent(typeof(ABtnEvents))]
	[RequireComponent(typeof(AButtonAnimController))]
	public abstract class JButton : AButton
	{
		private float lastClickTime;

		private bool isProcessingClick;

		private float doubleClickDelay => 0f;

		protected virtual bool SkipDoubleClickProtection => false;

		private void OnClickInternal()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public override IClickableObject GetIClickableObject()
		{
			return null;
		}
	}
}
