using System;

namespace JoyCraftSDK.Game.SandSimulation
{
	[Serializable]
	public enum SandBehaviour
	{
		None = 0,
		Static = 1,
		Solid = 2,
		MoveLikeSand = 11,
		MoveLikeLiquid = 12
	}
}
