using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public static class MathHelper
	{
		public static Vector3 GetQuadraticBezierPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default;
		}

		public static Vector3 GetCubicBezierPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default;
		}

		public static Vector3[] GetQuadraticBezierPath(Vector3 start, Vector3 control, Vector3 end, int resolution)
		{
			return null;
		}

		public static Vector3[] GetCubicBezierPath(Vector3 start, Vector3 control1, Vector3 control2, Vector3 end, int resolution)
		{
			return null;
		}

		public static Vector3[] GetArcPath(Vector3 start, Vector3 end, float height, int resolution)
		{
			return null;
		}

		internal static Vector3 GetPointOnPath(List<Vector3> paths, float progress)
		{
			return default;
		}
	}
}
