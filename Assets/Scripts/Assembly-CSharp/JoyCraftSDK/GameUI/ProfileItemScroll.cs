using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ProfileItemScroll : AScroll
	{
		[SerializeField]
		private ProfileItemCellView cellPrefab;

		[Tooltip("Chiều rộng/cao 1 item — đo lại theo prefab.")]
		[SerializeField]
		private float cellSize;

		private IReadOnlyList<ProfileVisualEntry> entries;

		private string selectedId;

		private Action<string> onSelect;

		public void SetItems(IReadOnlyList<ProfileVisualEntry> items, string selectedId, Action<string> onSelect)
		{
		}

		public void SetSelected(string id)
		{
		}

		private void SetCellSelected(string id, bool isSelected)
		{
		}

		private int FindIndex(string id)
		{
			return 0;
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

		private void OnItemClicked(string id)
		{
		}
	}
}
