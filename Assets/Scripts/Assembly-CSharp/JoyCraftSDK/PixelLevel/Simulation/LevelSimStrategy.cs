using System;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public enum LevelSimStrategy
	{
		HumanLike = 0,
		ZigzagBottomLR = 1,
		ZigzagBottomRL = 2,
		VerticalLR = 3,
		VerticalRL = 4,
		HorizontalFromL = 5,
		HorizontalFromR = 6,
		DiagZigzagLeftUp = 7,
		DiagZigzagLeftDown = 8,
		DiagZigzagRightUp = 9,
		DiagZigzagRightDown = 10,
		RandomSwipe = 11
	}
}
