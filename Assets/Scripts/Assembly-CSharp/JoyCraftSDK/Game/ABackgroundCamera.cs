using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ABackgroundCamera : JMonoBehaviour
	{
		public abstract Camera BackgroundCam { get; }
	}
}
