using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ShopIndexBar : JMonoBehaviour
	{
		[SerializeField]
		private JumpScrollBtn btnPrefab;

		[SerializeField]
		private Transform container;

		private readonly List<JumpScrollBtn> spawned;

		public void Build(IReadOnlyList<ShopSection> sections, IReadOnlyList<int> firstCellIndices, AScroll scroll)
		{
		}

		private void SetActiveIndex(int index)
		{
		}

		private void Clear()
		{
		}
	}
}
