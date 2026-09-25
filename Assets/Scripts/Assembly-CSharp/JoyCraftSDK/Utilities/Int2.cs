using System;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class Int2
	{
		public int x;

		public int y;

		public Int2(int x, int y)
		{
		}

		public Int2()
		{
		}

		public static implicit operator Vector2Int(Int2 i)
		{
			return default;
		}

		public static implicit operator Int2(Vector2Int v)
		{
			return null;
		}
	}
}
