using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainContactAccumulateJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<float> radii;

		[ReadOnly]
		public NativeParallelMultiHashMap<int, int> hash;

		[ReadOnly]
		public float cellSize;

		[ReadOnly]
		public float stiffness;

		[ReadOnly]
		public float softness;

		[ReadOnly]
		public float maxPush;

		[ReadOnly]
		public float intruderBias;

		[ReadOnly]
		public NativeArray<float2> velocities;

		[WriteOnly]
		public NativeArray<float2> delta;

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

		public NativeArray<int> diagCand;

		public NativeArray<int> diagContact;

		[ReadOnly]
		public int diagOn;

		[ReadOnly]
		public int diagPen;

		public NativeArray<int4> diagPenHist;

		public NativeArray<float2> diagPenStat;

		public const float PenB1 = 0.05f;

		public const float PenB2 = 0.15f;

		public const float PenB3 = 0.3f;

		[ReadOnly]
		public int localityProbe;

		[ReadOnly]
		public int usePacked;

		public NativeArray<float4> diagClamp;

		[ReadOnly]
		public NativeArray<float3> packed;

		[ReadOnly]
		public NativeArray<float2> packedPos;

		[ReadOnly]
		public NativeArray<float> packedVa;

		public void Execute(int i)
		{
		}

		private void Contact(int i, int j, int e, float2 pi, float ri, float spdI, ref float2 dN, ref int nc, ref int4 penHist, ref float2 penStat)
		{
		}
	}
}
