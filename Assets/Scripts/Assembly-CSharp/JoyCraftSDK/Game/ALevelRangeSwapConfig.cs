using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelRangeSwapConfig : JScriptableObject
	{
		public abstract int LevelStart { get; }

		public abstract int LevelFinish { get; }

		public abstract float MoveTime { get; }

		public abstract Ease MoveEase { get; }

		public abstract float OffscreenMargin { get; }

		public abstract Vector2 GetEnterDir(SwapElementKind kind);

		public abstract Vector2 GetExitDir(SwapElementKind kind);

		public bool IsInRange(int level)
		{
			return false;
		}

		public bool ShouldSwapAfter(int currentLevel)
		{
			return false;
		}
	}
}
