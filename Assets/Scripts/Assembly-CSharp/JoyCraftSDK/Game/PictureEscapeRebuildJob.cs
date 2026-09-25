using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	internal struct PictureEscapeRebuildJob : IJob
	{
		public int Width;

		public int Height;

		public int ExitMinPx;

		public int ExitMaxPx;

		public int SlideCells;

		public bool HeldPassable;

		public bool RepairFrontier;

		[ReadOnly]
		public NativeArray<PictureCellState> State;

		public NativeArray<bool> Dst;

		public NativeArray<bool> CanDrop;

		public NativeArray<int> Dist;

		public NativeList<int> FrontierAdds;

		public void Execute()
		{
		}

		private bool Passable(int i, bool heldPassable)
		{
			return false;
		}

		private void SlideRow(int row, bool heldPassable)
		{
		}

		private bool DropsFrom(int px, int py)
		{
			return false;
		}

		private bool IsEligible(int px, int py)
		{
			return false;
		}
	}
}
