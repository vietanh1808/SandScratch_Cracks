using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public class GameConstants : JMonoBehaviour
	{
		public static class Time
		{
			public const float PopupAutoCloseDelay = 2f;

			public const float CoinChangeSfxDelay = 0.7f;

			public const float ShowWinScreenDelay = 1.2f;
		}

		public const string DataPresetPath = "GameSDK/DataPreset/";

		public const string GameSDKPath = "GameSDK/";

		public const string GoogleSheetEditor = "Game/Google Sheet Editor/";

		public const float Duration_To_Next_Ads_In_Minutes = 0.25f;

		public static readonly List<SceneIndex> GameScenes;

		public const string TestVar = "JoyCraft/Quests/TestVars/";

		public static readonly Vector2Int[] ADJACENT_OFFSETS_4;

		public static readonly Vector2Int[] ADJACENT_OFFSETS_8;

		public const float VFX_DELAY_PER_ORDER = 0.1f;

		public static Vector2Int[] COMBINED_DIRECTIONS => null;

		public static bool IsGameplayScene(SceneIndex scene)
		{
			return false;
		}

		public static Vector2Int[] GetMergeDirectionOffsets(MergeDirections direction)
		{
			return null;
		}

		public static int Get1DIndexFrom2D(Vector2Int size2D, Vector2Int pos2D)
		{
			return 0;
		}

		public static Vector2Int Get2DIndexFrom1D(Vector2Int size2D, int index1D)
		{
			return default;
		}

		public static Vector2Int GetDirectionOffset(Direction direction)
		{
			return default;
		}

		public static Vector2Int GetCornerOffset(CornerDirection corner)
		{
			return default;
		}
	}
}
