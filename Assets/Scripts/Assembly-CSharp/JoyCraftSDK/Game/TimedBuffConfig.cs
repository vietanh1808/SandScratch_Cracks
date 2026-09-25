using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TimedBuffConfig", menuName = "GameSDK/TimedBuffConfig")]
	public class TimedBuffConfig : ATimedBuffConfig
	{
		[SerializeField]
		private List<TimedBuffConfigPoint> configPoints;

		public override IReadOnlyList<TimedBuffConfigPoint> GetConfigPoints()
		{
			return null;
		}

		public override TimedBuffConfigPoint GetConfigPoint(BuffType type)
		{
			return null;
		}
	}
}
