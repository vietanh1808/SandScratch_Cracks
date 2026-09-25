using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeLevelScroll : AScroll
	{
		[SerializeField]
		private LevelStageCellView cellPrefab;

		[SerializeField]
		private float cellSize;

		[SerializeField]
		private int levelCount;

		private int TopLevel => 0;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnGameInited(ref AEventManager.OnGameInited eventData)
		{
		}

		private void ComputeLevelCount()
		{
		}

		private void RebuildToBottom()
		{
		}

		public override int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public override float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public override EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
