using UnityEngine;

namespace TouchScript.Layers
{
	public class ProjectionParams
	{
		public virtual Vector3 ProjectTo(Vector2 screenPosition, Plane projectionPlane)
		{
			return default;
		}

		public virtual Vector2 ProjectFrom(Vector3 worldPosition)
		{
			return default;
		}
	}
}
