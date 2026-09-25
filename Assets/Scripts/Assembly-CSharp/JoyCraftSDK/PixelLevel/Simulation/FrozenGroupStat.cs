using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class FrozenGroupStat : JBase
	{
		public int GroupId { get; set; }

		public int Col { get; set; }

		public int CountInitial { get; set; }

		public int WinRevealed { get; set; }

		public int WinUnrevealed { get; set; }

		public int WinJarsLeftMin { get; set; }

		public int WinJarsLeftMax { get; set; }

		public int LossRevealed { get; set; }

		public int LossUnrevealed { get; set; }

		public int LossJarsLeftMin { get; set; }

		public int LossJarsLeftMax { get; set; }
	}
}
