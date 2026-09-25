using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public struct GrainOccupancyField
	{
		public float2 worldOrigin;

		public float2 invRow0;

		public float2 invRow1;

		public float2 pxAxisWorld;

		public float2 pyAxisWorld;

		public int occWidth;

		public int occHeight;

		public int occCellPixels;

		public int pictureWidth;

		public int pictureHeight;

		public float pushStrength;

		public float maxStep;

		public int smoothRadius;

		public int dilateCells;

		public int edgeApronCells;

		public int ejectSearchCells;

		public int creepWindow;

		public float creepSpeed;

		public float creepSlopeMin;

		public int creepLateralMax;

		public float4 colScrollPy;

		public int colCount;

		public float colWidthPx;

		public int viewportRows;
	}
}
