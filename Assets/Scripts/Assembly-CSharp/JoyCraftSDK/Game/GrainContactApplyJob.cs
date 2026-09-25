using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainContactApplyJob : IJobParallelFor
	{
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<float2> delta;

		[ReadOnly]
		public int hasOcc;

		[ReadOnly]
		public GrainOccupancyField occ;

		[ReadOnly]
		public NativeArray<byte> occSnapshot;

		[ReadOnly]
		public NativeArray<byte> occSnapshotRaw;

		[ReadOnly]
		public NativeArray<float2> occNormals;

		[ReadOnly]
		public float dt;

		[ReadOnly]
		public int hasSdf;

		[ReadOnly]
		public GrainSdfField sdf;

		[ReadOnly]
		public NativeArray<GrainWallSegment> segments;

		[ReadOnly]
		public int hasDoor;

		[ReadOnly]
		public GrainWallSegment door;

		[ReadOnly]
		public float wallCompliance;

		[ReadOnly]
		public NativeArray<byte> ghost;

		[ReadOnly]
		public GrainWallGrid wallGrid;

		[ReadOnly]
		public NativeArray<int> wallCellStart;

		[ReadOnly]
		public NativeArray<int> wallCellItems;

		public void Execute(int i)
		{
		}
	}
}
