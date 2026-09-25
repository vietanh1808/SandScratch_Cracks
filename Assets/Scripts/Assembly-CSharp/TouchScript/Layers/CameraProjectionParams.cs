using UnityEngine;

namespace TouchScript.Layers
{
	public class CameraProjectionParams : ProjectionParams
	{
		protected Camera camera;

		public CameraProjectionParams(Camera camera)
		{
		}

		public override Vector3 ProjectTo(Vector2 screenPosition, Plane projectionPlane)
		{
			return default;
		}

		public override Vector2 ProjectFrom(Vector3 worldPosition)
		{
			return default;
		}
	}
}
