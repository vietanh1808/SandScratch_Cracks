using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public struct GrainSdfField
	{
		public float4x4 worldToLocal;

		public float4x4 localToWorld;

		public float halfBody;

		public float rIn;

		public float rOut;

		public float gapHalf;

		public float edgeRadius;

		public float radiusLocal;

		public float doorThr;

		public float beltHalfX;

		public float beltTopY;

		public int segmentCount;

		public float2 respawnLocal;

		public float chuteInHalf;

		public float wallX;

		public float chuteTopY;

		public float funnelTopY;

		public float wallTop;

		public int hasTopWall;

		public float bboxHalfX;
	}
}
