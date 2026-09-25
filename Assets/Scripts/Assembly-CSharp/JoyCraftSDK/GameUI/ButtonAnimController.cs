using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(AButtonAnim))]
	public class ButtonAnimController : AButtonAnimController
	{
		[SerializeField]
		private AButtonAnim buttonAnim;

		public override void Show(bool instant = false)
		{
		}

		public override void Hide(bool instant = false)
		{
		}

		public override bool IsShowing()
		{
			return false;
		}

		private void OnValidate()
		{
		}
	}
}
