using System;
using System.Collections.Generic;

namespace JoyCraftSDK.Game
{
	public interface ISandFlowBackend
	{
		int RegionPixelCount { get; }

		float FillRatio { get; }

		event Action<int, int> OnPixelArrivedAtJar;

		void Build(PixelLevelData pixelLevelData, bool grainyLook, List<ColorJarColumnData> colorJarColumns);

		void AcceptSand(SandEmitRequest request);

		int GhostifyGrainsOfColor(int colorId, float releaseY);

		void Clear();
	}
}
