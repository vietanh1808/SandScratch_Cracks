using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class RewardDisplayData : JBase
	{
		public RewardKind Kind { get; }

		public int Amount { get; }

		public RewardDisplayData(RewardKind kind, int amount)
		{
		}
	}
}
