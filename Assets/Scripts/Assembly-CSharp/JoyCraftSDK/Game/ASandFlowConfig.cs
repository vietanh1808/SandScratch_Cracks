using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ASandFlowConfig : JScriptableObject
	{
		public abstract ConveyorShapeData ConveyorShape { get; }

		public abstract GrainTuningConfig TuningConfig { get; }

		public abstract ObiFlowLayoutConfig LayoutConfig { get; }

		public abstract AFrozenShapeLibrary FrozenShapeLibrary { get; }
	}
}
