using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class PixelClusterColorMap : JBase
	{
		[SerializeField]
		private int packedRgb;

		[SerializeField]
		private int value;

		public int PackedRgb => 0;

		public int Value => 0;

		public PixelClusterColorMap()
		{
		}

		public PixelClusterColorMap(int packedRgbKey, int colorValue)
		{
		}

		public void SetValue(int colorValue)
		{
		}
	}
}
