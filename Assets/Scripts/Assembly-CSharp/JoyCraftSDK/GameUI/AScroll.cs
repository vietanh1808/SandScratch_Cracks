using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AScroll : JMonoBehaviour, IEnhancedScrollerDelegate
	{
		[SerializeField]
		protected EnhancedScroller scroller;

		protected void OnValidate()
		{
		}

		protected virtual void Start()
		{
		}

		public abstract int GetNumberOfCells(EnhancedScroller scroller);

		public abstract float GetCellViewSize(EnhancedScroller scroller, int dataIndex);

		public abstract EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex);

		protected virtual void Setup()
		{
		}

		public virtual void JumpToIndex(int dataIndex, bool center = false, bool animate = true)
		{
		}
	}
}
