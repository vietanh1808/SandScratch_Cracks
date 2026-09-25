using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class SwipeBatch : JBase
	{
		private readonly List<int> _cells;

		private readonly List<float> _arcs;

		private readonly Dictionary<int, int> _slotOf;

		private readonly List<int> _revertBook;

		private readonly List<int> _sortIdx;

		private readonly List<int> _permCells;

		private int _drainCursor;

		private int _liveCount;

		private int _width;

		private int _slabThickness;

		private readonly Comparison<int> _drainOrder;

		public int Count => 0;

		public bool IsEmpty => false;

		public bool Drained => false;

		public bool RevertOnFinish { get; private set; }

		public IReadOnlyList<int> RevertBook => null;

		public IReadOnlyList<int> Cells => null;

		public void Reset(int width)
		{
		}

		public void MarkNoRevert()
		{
		}

		public bool Contains(int cellIndex)
		{
			return false;
		}

		public void Append(int cellIndex, float strokeArc)
		{
		}

		public void CloseAndOrder(int slabCells)
		{
		}

		public bool TryTakeNext(out int px, out int py, out int cellIndex)
		{
			px = default;
			py = default;
			cellIndex = default;
			return false;
		}

		public void MarkRevertCandidate(int cellIndex)
		{
		}

		private void Compact()
		{
		}

		private int CompareDrainOrder(int a, int b)
		{
			return 0;
		}
	}
}
