using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainGrainCcdJob : IJobParallelFor
	{
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<float2> posPrev;

		[ReadOnly]
		public NativeArray<float2> velocities;

		[ReadOnly]
		public NativeArray<float> radii;

		[ReadOnly]
		public float cellSize;

		[ReadOnly]
		public float dt;

		[ReadOnly]
		public float ccdGate;

		[ReadOnly]
		public float ccdMaxPull;

		[ReadOnly]
		public NativeParallelMultiHashMap<int, int> hash;

		[ReadOnly]
		public NativeArray<int> gridCellStart;

		[ReadOnly]
		public NativeArray<int> gridEntryIdx;

		[ReadOnly]
		public NativeArray<GrainCellGrid> gridInfo;

		[ReadOnly]
		public int useGrid;

		[ReadOnly]
		public float uniformRadius;

		public NativeArray<byte> diag;

		[ReadOnly]
		public int diagOn;

		public void Execute(int i)
		{
		}

		private void ScanCell(int2 cell, int i, float2 a, float2 di, float2 viStep, float ri, ref float tMin)
		{
		}

		private void TestCandidate(int i, int j, float2 a, float2 di, float2 viStep, float ri, ref float tMin)
		{
		}
	}
}
