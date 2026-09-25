using System;

namespace JoyCraftSDK
{
	[Serializable]
	public enum EventPriority
	{
		Lowest = -200,
		Low = -100,
		Default = 0,
		High = 100,
		Highest = 200
	}
}
