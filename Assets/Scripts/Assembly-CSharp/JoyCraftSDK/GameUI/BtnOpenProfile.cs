using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnOpenProfile : JButton
	{
		[SerializeField]
		private Image faceImage;

		[SerializeField]
		private Image frameImage;

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnClick()
		{
		}

		private void OnGameInited(ref AEventManager.OnGameInited eventData)
		{
		}

		private void OnProfileChanged(ref AEventManager.OnProfileChanged eventData)
		{
		}

		private void Refresh()
		{
		}
	}
}
