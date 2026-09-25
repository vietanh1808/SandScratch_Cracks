using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	[CreateAssetMenu(fileName = "LevelRangeSwapConfig", menuName = "GameSDK/LevelRangeSwapConfig")]
	public class LevelRangeSwapConfig : ALevelRangeSwapConfig
	{
		private const string Group_Range = "Range";

		private const string Group_Tween = "Tween";

		private const string Group_Direction = "Swap Direction";

		[Tooltip("Level (1-based) ĐẦU dải bật swap.")]
		[SerializeField]
		private int levelStart;

		[Tooltip("Level (1-based) CUỐI dải bật swap. Finish -> level kế out-of-range -> đi path ScreenWin chuẩn.")]
		[SerializeField]
		private int levelFinish;

		[Tooltip("Thời gian (giây) tween trượt mảnh cũ ra + mảnh mới vào.")]
		[SerializeField]
		[Min(0f)]
		private float moveTime;

		[Tooltip("Ease của tween trượt.")]
		[SerializeField]
		private Ease moveEase;

		[Tooltip("Khoảng đệm (world) cộng thêm ngoài footprint mảnh khi tính điểm off-screen -> mảnh trượt HẲN khỏi màn.")]
		[SerializeField]
		[Min(0f)]
		private float offscreenMargin;

		[Tooltip("Hướng trượt cho TỪNG object swap (1 dòng/object, khoá theo Kind). Thiếu dòng cho 1 object -> LogError + fallback Down. Mặc định game: Picture enter/exit Down, Jar enter/exit Up.")]
		[SerializeField]
		private List<SwapDirectionEntry> swapDirections;

		public override int LevelStart => 0;

		public override int LevelFinish => 0;

		public override float MoveTime => 0f;

		public override Ease MoveEase => Ease.Unset;

		public override float OffscreenMargin => 0f;

		public override Vector2 GetEnterDir(SwapElementKind kind)
		{
			return default;
		}

		public override Vector2 GetExitDir(SwapElementKind kind)
		{
			return default;
		}

		private Vector2 ResolveDir(SwapElementKind kind, bool isEnter)
		{
			return default;
		}

		private static Vector2 ToVector2(SwapDirection dir)
		{
			return default;
		}
	}
}
