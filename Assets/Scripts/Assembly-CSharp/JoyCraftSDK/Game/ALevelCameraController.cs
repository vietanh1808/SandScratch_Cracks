using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelCameraController : JMonoBehaviour
	{
		public abstract void Reposition(Vector3 targetPosition, Vector3 levelSize);
	}
}
