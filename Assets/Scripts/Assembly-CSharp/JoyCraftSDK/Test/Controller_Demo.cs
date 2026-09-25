using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class Controller_Demo : MonoBehaviour, IEnhancedScrollerDelegate
	{
		private List<DataDemo> _data;

		public EnhancedScroller myScroller;

		public CellViewDemo demoCellViewPrefab;

		private void Start()
		{
		}

		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
