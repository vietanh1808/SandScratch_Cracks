using UnityEngine;

namespace TouchScript.Layers
{
	public class WorldSpaceCanvasProjectionParams : ProjectionParams
	{
		protected Canvas canvas;

		protected RenderMode mode;

		protected Camera camera;

		public WorldSpaceCanvasProjectionParams(Canvas canvas)
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
