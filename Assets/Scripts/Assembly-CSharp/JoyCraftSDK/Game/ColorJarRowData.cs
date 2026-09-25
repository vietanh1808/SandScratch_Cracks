using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class ColorJarRowData : JBase
	{
		[Tooltip("Stack-depth chèn hàng (0 = head, đang nhận).")]
		[SerializeField]
		[Min(0f)]
		private int rowIndex;

		[Tooltip("Jar theo cột (jars[c] chèn vào cột c). Cột thiếu jar (index vượt list) bị bỏ qua.")]
		[SerializeField]
		private List<ColorJarData> jars;

		public int RowIndex => 0;

		public List<ColorJarData> Jars => null;

		public void SetRowIndex(int value)
		{
		}
	}
}
