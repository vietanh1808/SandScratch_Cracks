using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public readonly struct FinishedLevelSnapshot
	{
		public readonly string GameMode;

		public readonly string SessionId;

		public readonly int LevelId;

		public readonly float TimeSpent;

		public readonly int Attempts;

		public readonly int LoseIndex;

		public readonly int ExitIndex;

		public readonly float DurationTotalStart;

		public readonly float DurationTotalEnd;

		public readonly LevelPlayType PlayType;

		public readonly string VariantId;

		public readonly int ItemsTotal;

		public readonly int ItemsCleared;

		public readonly LevelFinishReason Reason;

		public readonly LevelFailReason FailReason;

		private readonly Dictionary<BoosterType, int> _boostersUsage;

		private readonly List<int> _moveSequence;

		public string MoveSequenceString => null;

		public FinishedLevelSnapshot(string gameMode, string sessionId, int levelId, float timeSpent, int attempts, Dictionary<BoosterType, int> boostersUsage, List<int> moveSequence, int loseIndex, int exitIndex, float durationTotalStart, float durationTotalEnd, LevelPlayType playType, string variantId, int itemsTotal, int itemsCleared, LevelFinishReason reason, LevelFailReason failReason)
		{
			GameMode = null;
			SessionId = null;
			LevelId = 0;
			TimeSpent = 0f;
			Attempts = 0;
			LoseIndex = 0;
			ExitIndex = 0;
			DurationTotalStart = 0f;
			DurationTotalEnd = 0f;
			PlayType = LevelPlayType.Home;
			VariantId = null;
			ItemsTotal = 0;
			ItemsCleared = 0;
			Reason = LevelFinishReason.None;
			FailReason = LevelFailReason.None;
			_boostersUsage = null;
			_moveSequence = null;
		}

		public static FinishedLevelSnapshot ForAbandon(string gameMode, string sessionId, int levelId, float timeSpent, int attempts, int loseIndex, int exitIndex, float durationTotal, LevelPlayType playType, string variantId, int itemsTotal, int itemsCleared)
		{
			return default;
		}

		public int GetBoosterUsage(BoosterType type)
		{
			return 0;
		}
	}
}
