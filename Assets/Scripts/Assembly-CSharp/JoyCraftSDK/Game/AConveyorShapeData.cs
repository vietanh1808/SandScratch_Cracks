using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AConveyorShapeData : JScriptableObject
	{
		public abstract float BodyLength { get; }

		public abstract float ChannelWidth { get; }

		public abstract int OuterWallThicknessCells { get; }

		public abstract float InnerHoleRadius { get; }

		public abstract int InnerWallThicknessCells { get; }

		public abstract ConveyorCapacityMode CapacityMode { get; }

		public abstract int MaxPixelsManual { get; }

		public abstract float FillRatio { get; }

		public abstract int MaxGrainsManual { get; }
	}
}
