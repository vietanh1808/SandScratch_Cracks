using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class PixelColorRemap : JBase
	{
		[SerializeField]
		private int from;

		[SerializeField]
		private int to;

		[SerializeField]
		private bool isRegion;

		[SerializeField]
		private int seedX;

		[SerializeField]
		private int seedY;

		[SerializeField]
		private bool singleCell;

		public int From => 0;

		public int To => 0;

		public bool IsRegion => false;

		public int SeedX => 0;

		public int SeedY => 0;

		public bool SingleCell => false;

		public PixelColorRemap()
		{
		}

		public PixelColorRemap(int fromValue, int toValue)
		{
		}

		public PixelColorRemap(int seedXValue, int seedYValue, int fromValue, int toValue)
		{
		}

		public PixelColorRemap(int seedXValue, int seedYValue, int fromValue, int toValue, bool singleCellValue)
		{
		}

		public void SetTo(int toValue)
		{
		}
	}
}
