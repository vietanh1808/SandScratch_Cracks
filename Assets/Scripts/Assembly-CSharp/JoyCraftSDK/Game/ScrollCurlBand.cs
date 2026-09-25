using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class ScrollCurlBand : JBase
	{
		private readonly AScrollCurl _curlView;

		private readonly LevelSpawner _levelSpawner;

		private readonly int _pxMin;

		private readonly int _bandRows;

		private readonly int _viewScale;

		private readonly int _pictureHeight;

		private readonly int _viewportHeight;

		private readonly int _texWidth;

		private readonly int _texHeight;

		private readonly Color32[] _bandPixels;

		private Texture2D _bandTexture;

		private int _filledWindowTop;

		public ScrollCurlBand(AScrollCurl curlView, LevelSpawner levelSpawner, int pxMin, int pxMax, int bandRows, int viewScale, int pictureHeight, int viewportHeight, float cell)
		{
		}

		public void Tick(float scrollRows)
		{
		}

		public void Dispose()
		{
		}

		private void FillBand(int windowTopViewRow)
		{
		}
	}
}
