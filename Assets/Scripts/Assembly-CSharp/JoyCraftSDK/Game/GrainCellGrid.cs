using Unity.Collections;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public struct GrainCellGrid
	{
		public int2 minCell;

		public int width;

		public int height;

		public float cellSize;

		public int ring;

		public bool RowSpan(in NativeArray<int> cellStart, int cy, int x0, int x1, out int begin, out int end)
		{
			begin = default;
			end = default;
			return false;
		}
	}
}
