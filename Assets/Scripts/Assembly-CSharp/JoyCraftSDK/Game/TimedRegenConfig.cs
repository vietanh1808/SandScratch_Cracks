using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TimedRegenConfig", menuName = "GameSDK/TimedRegenConfig")]
	public class TimedRegenConfig : ATimedRegenConfig
	{
		[SerializeField]
		private List<TimedRegenConfigPoint> configPoints;

		public override IReadOnlyList<TimedRegenConfigPoint> GetConfigPoints()
		{
			return null;
		}

		public override TimedRegenConfigPoint GetConfigPoint(RegenResourceType type)
		{
			return null;
		}
	}
}
