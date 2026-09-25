using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public class RouteFirstSearchProgress : JBase
	{
		public int Total;

		public int Screened;

		public int HeldOutDone;

		public int HeldOutPending;

		public int Rounds;
	}
}
