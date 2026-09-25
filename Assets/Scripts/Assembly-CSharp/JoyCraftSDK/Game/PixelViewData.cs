using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class PixelViewData : JBase
	{
		[SerializeField]
		private int width;

		[SerializeField]
		private int height;

		[SerializeField]
		private Color32[] colors;

		public int Width => 0;

		public int Height => 0;

		public bool HasData => false;

		public bool InBounds(int x, int y)
		{
			return false;
		}

		public int IndexFlat(int x, int y)
		{
			return 0;
		}

		public Color32 GetColor(int x, int y)
		{
			return default;
		}

		public void Resize(int w, int h)
		{
		}

		public void SetColor(int x, int y, Color32 color)
		{
		}

		public void SetAll(Color32[] source)
		{
		}

		public void ClearData()
		{
		}
	}
}
