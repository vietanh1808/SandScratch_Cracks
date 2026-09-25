using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class ObiFlowEmitters : JBase
	{
		public struct HarvestedGrain
		{
			public Vector3 worldPos;

			public int carried;

			public Color renderColor;

			public int colorId;

			public float radius;
		}
	}
}
