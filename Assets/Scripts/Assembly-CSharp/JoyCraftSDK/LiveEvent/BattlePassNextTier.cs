namespace JoyCraftSDK.LiveEvent
{
	public readonly struct BattlePassNextTier
	{
		public readonly bool HasNext;

		public readonly int Tier;

		public readonly int StepCost;

		public readonly int StepProgress;

		public readonly int Shortfall;

		public static BattlePassNextTier None => default;

		public BattlePassNextTier(int tier, int stepCost, int stepProgress)
		{
			HasNext = false;
			Tier = 0;
			StepCost = 0;
			StepProgress = 0;
			Shortfall = 0;
		}
	}
}
