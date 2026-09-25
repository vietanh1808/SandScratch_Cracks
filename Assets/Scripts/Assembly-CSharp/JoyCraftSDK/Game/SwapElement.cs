using UnityEngine;

namespace JoyCraftSDK.Game
{
	public readonly struct SwapElement
	{
		public readonly Transform Target;

		public readonly Vector3 RestLocalPos;

		public readonly SwapElementKind Kind;

		public SwapElement(Transform target, Vector3 restLocalPos, SwapElementKind kind)
		{
			Target = null;
			RestLocalPos = default;
			Kind = SwapElementKind.Picture;
		}
	}
}
