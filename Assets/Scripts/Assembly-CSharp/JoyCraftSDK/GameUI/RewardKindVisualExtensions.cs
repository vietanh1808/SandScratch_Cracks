using JoyCraftSDK.IAP;

namespace JoyCraftSDK.GameUI
{
	public static class RewardKindVisualExtensions
	{
		public static bool TryGetEffectType(this RewardKind kind, out EffectType effectType)
		{
			effectType = default;
			return false;
		}

		public static string ToAmountLabel(this RewardKind kind, int amount)
		{
			return null;
		}
	}
}
