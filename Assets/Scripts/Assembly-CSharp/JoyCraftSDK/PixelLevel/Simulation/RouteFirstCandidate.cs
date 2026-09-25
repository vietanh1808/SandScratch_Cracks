using System;
using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public class RouteFirstCandidate : JBase
	{
		public string Label;

		public string Parent;

		public int Round;

		public List<ColorJarColumnData> Columns;

		public bool Screened;

		public RouteFirstScore Screen;

		public bool HeldOutDone;

		public RouteFirstScore HeldOut;

		public string Signature()
		{
			return null;
		}
	}
}
