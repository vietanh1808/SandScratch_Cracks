using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BackgroundUIManager : ABackgroundUIManager
	{
		[SerializeField]
		private Image backgroundImage;

		public override void Awake()
		{
		}

		public override void SetBackgroundImg(Sprite img)
		{
		}

		protected override void Subscribe()
		{
		}

		private void OnBackgroundImageChange(Sprite img)
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
