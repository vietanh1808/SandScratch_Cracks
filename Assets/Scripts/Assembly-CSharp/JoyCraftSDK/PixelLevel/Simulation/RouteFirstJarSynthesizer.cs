using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstJarSynthesizer : JBase
	{
		private class DrainState : JBase
		{
			public int[] ActiveIndex;

			public int[] Received;

			public Dictionary<int, int> Belt;
		}

		private class ReplayResult : JBase
		{
			public float Peak;

			public int PeakMove;

			public int NeedMove;

			public DrainState State;
		}

		private DrainState NewDrainState(int columnCount)
		{
			return null;
		}

		private List<List<RouteFirstJar>> CloneColumns(List<List<RouteFirstJar>> columns)
		{
			return null;
		}

		public RouteFirstSchedule Synthesize(RouteFirstRoute route, RouteFirstParams routeFirstParams)
		{
			return null;
		}

		private int FindLeftmostReceivingColumn(List<List<RouteFirstJar>> columns, DrainState state, int colorId)
		{
			return 0;
		}

		private void Drain(List<List<RouteFirstJar>> columns, DrainState state)
		{
		}

		private float StuckFill(DrainState state, RouteFirstRoute route, RouteFirstParams routeFirstParams)
		{
			return 0f;
		}

		private bool HasNeed(List<List<RouteFirstJar>> columns, DrainState state, Dictionary<int, int> remaining)
		{
			return false;
		}

		private ReplayResult Replay(List<List<RouteFirstJar>> columns, Dictionary<int, int> remaining, RouteFirstRoute route, RouteFirstParams routeFirstParams, bool stopAtNeed, List<string> diagnosticLog)
		{
			return null;
		}

		private (int, int) ResolveNeediestColor(DrainState state, Dictionary<int, int> remaining, RouteFirstParams routeFirstParams)
		{
			return default;
		}

		private bool PlaceNext(List<List<RouteFirstJar>> columns, Dictionary<int, int> remaining, RouteFirstRoute route, RouteFirstParams routeFirstParams, List<string> log)
		{
			return false;
		}

		private bool PlaceNextLeftmost(List<List<RouteFirstJar>> columns, Dictionary<int, int> remaining, RouteFirstRoute route, RouteFirstParams routeFirstParams)
		{
			return false;
		}

		private float EvaluateCandidate(List<List<RouteFirstJar>> columns, Dictionary<int, int> remaining, RouteFirstRoute route, RouteFirstParams routeFirstParams, int candidate, int color, int cap)
		{
			return 0f;
		}
	}
}
