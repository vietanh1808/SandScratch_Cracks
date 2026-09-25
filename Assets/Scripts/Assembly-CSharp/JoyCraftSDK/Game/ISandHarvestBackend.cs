using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public interface ISandHarvestBackend
	{
		int HarvestJar(Bounds mouthWorldBounds, int colorId, int maxAcceptPixels, List<ObiFlowEmitters.HarvestedGrain> results = null, bool raiseArrival = true);

		int HarvestDirectToJar(Func<int, int, DirectJarVerdict> verdict, List<ObiFlowEmitters.HarvestedGrain> results);

		void DebugCountJar(Bounds mouthWorldBounds, int colorId, out int total, out int matching);
	}
}
