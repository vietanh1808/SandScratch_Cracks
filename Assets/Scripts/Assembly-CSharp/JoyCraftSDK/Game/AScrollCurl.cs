using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class AScrollCurl : JMonoBehaviour
	{
		public abstract void Setup(float bandWorldHeight, float columnWorldWidth, Texture2D texture);

		public abstract void SetUvWindow(float v0, float v1);

		public abstract void SetVisible(bool visible);
	}
}
