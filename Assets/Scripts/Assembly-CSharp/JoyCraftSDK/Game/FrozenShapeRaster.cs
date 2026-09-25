using UnityEngine;

namespace JoyCraftSDK.Game
{
	public static class FrozenShapeRaster
	{
		public static bool Contains(FrozenShapeDef shapeDef, FrozenPlacementData placement, int px, int py)
		{
			return false;
		}

		public static Rect Bounds(FrozenShapeDef shapeDef, FrozenPlacementData placement)
		{
			return default;
		}

		public static int ColumnOf(FrozenPlacementData placement, int pictureWidth, int columnCount)
		{
			return 0;
		}

		public static bool FitsInPicture(FrozenShapeDef shapeDef, FrozenPlacementData placement, int pictureWidth, int pictureHeight)
		{
			return false;
		}

		public static bool FitsInSingleColumn(FrozenShapeDef shapeDef, FrozenPlacementData placement, int pictureWidth, int columnCount)
		{
			return false;
		}

		private static Vector2 RotateInverse(float dx, float dy, float rotationDeg)
		{
			return default;
		}
	}
}
