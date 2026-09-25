using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.AdminTest
{
	public abstract class AAdminTestCellView : JCellView
	{
		public virtual float CellSize => 0f;

		public static float CalculateGridCellSize(int buttonCount, int columns, float cellHeight, float spacingY, float headerAndPadding)
		{
			return 0f;
		}
	}
}
