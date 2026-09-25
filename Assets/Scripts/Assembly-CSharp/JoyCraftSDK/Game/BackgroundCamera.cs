using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class BackgroundCamera : ABackgroundCamera
	{
		[SerializeField]
		private Camera backgroundCam;

		public override Camera BackgroundCam => null;

		private void OnValidate()
		{
		}
	}
}
