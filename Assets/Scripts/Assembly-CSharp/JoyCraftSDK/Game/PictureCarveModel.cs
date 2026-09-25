using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using Unity.Collections;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class PictureCarveModel : JBase
	{
		private readonly PictureCellState[] _state;

		private readonly int[] _colorId;

		private readonly bool[] _escape;

		private readonly bool[] _escapeOpt;

		private readonly int[] _occCount;

		private int _solidCount;

		private int _initialSolidCount;

		private readonly int[] _solidCountByColor;

		private readonly List<int> _colorsPresent;

		private int _neverConvertedCount;

		private int _revertVersion;

		private readonly int _exitMinPx;

		private readonly int _exitMaxPx;

		private readonly HashSet<int> _frontier;

		private int _dirtyMinX;

		private int _dirtyMinY;

		private int _dirtyMaxX;

		private int _dirtyMaxY;

		private byte[] _frozen;

		private const int MaxFrozenGroupId = 254;

		private readonly int _slideCells;

		private readonly bool[] _canDrop;

		private readonly int[] _dist;

		private bool _escapeDirty;

		private bool _escapeOptDirty;

		private bool _fineOccDirty;

		private static bool _fpEscColdDone;

		private static int _fpEscOptCount;

		public int Width { get; }

		public int Height { get; }

		public int OccCellPixels { get; }

		public int OccWidth { get; }

		public int OccHeight { get; }

		public int FrontierCount => 0;

		public int SolidCount => 0;

		public IReadOnlyList<int> ColorsPresent => null;

		public bool AllPixelsSwiped => false;

		public int RevertVersion => 0;

		public PictureCarveModel(int width, int height, int[] paintedColorIds, int occCellPixels = 4, int exitMinPx = -1, int exitMaxPx = -1, int slideCells = 8)
		{
		}

		public PictureCellState State(int px, int py)
		{
			return PictureCellState.Solid;
		}

		public int ColorAt(int px, int py)
		{
			return 0;
		}

		public bool CanEscapeToExit(int px, int py)
		{
			return false;
		}

		public bool IsOccupied(int ox, int oy)
		{
			return false;
		}

		public int SolidCountOfColor(int colorId)
		{
			return 0;
		}

		public bool IsFrozen(int px, int py)
		{
			return false;
		}

		public int FrozenGroupAt(int px, int py)
		{
			return 0;
		}

		public int BottomSolidRowIndex(int pxMin, int pxMax)
		{
			return 0;
		}

		private bool Blocks(int i)
		{
			return false;
		}

		public void CopyOccupancyTo(NativeArray<byte> dst)
		{
		}

		public void CopyFineOccupancyTo(NativeArray<byte> dst)
		{
		}

		public bool ConsumeOccDirtyRect(out RectInt occRect)
		{
			occRect = default;
			return false;
		}

		public void SetFrozen(int px, int py, int groupId)
		{
		}

		public void ClearFrozenGroup(int groupId)
		{
		}

		public void CarveBrush(int px, int py, int radius, List<int> newlyHeld = null, Func<int, int, bool> canCarveCell = null)
		{
		}

		public void CarveAllRemaining(List<int> newlyHeld = null, Func<int, int, bool> canCarveCell = null)
		{
		}

		public void CarveAllRemainingOfColor(int colorId, List<int> newlyHeld = null, Func<int, int, bool> canCarveCell = null)
		{
		}

		public bool CarveCell(int px, int py)
		{
			return false;
		}

		public void BeginConvertWave()
		{
		}

		public bool TryPeekFrontierLowest(out int px, out int py)
		{
			px = default;
			py = default;
			return false;
		}

		public bool ConvertCell(int px, int py)
		{
			return false;
		}

		public bool ConvertCell(int px, int py, bool requireEscape)
		{
			return false;
		}

		private bool Passable(int i, bool heldPassable)
		{
			return false;
		}

		private void EnsureEscape()
		{
		}

		private void EnsureEscapeOpt()
		{
		}

		private void RebuildEscapeField(bool[] dst, bool heldPassable, bool repairFrontier)
		{
		}

		private void RebuildEscapeFieldManaged(bool[] dst, bool heldPassable, bool repairFrontier)
		{
		}

		private void SlideRow(bool[] dst, int row, bool heldPassable)
		{
		}

		private bool DropsFrom(int px, int py)
		{
			return false;
		}

		private bool IsEligible(int px, int py)
		{
			return false;
		}

		private void CheckFrontier(int px, int py)
		{
		}

		public bool CanConvertNowOptimistic(int px, int py)
		{
			return false;
		}

		public void SyncEscapeOptimistic()
		{
		}

		public bool RevertCell(int px, int py)
		{
			return false;
		}

		private bool In(int x, int y)
		{
			return false;
		}

		private int OccIndex(int px, int py)
		{
			return 0;
		}

		private void MarkOccDirty(int ox, int oy)
		{
		}
	}
}
