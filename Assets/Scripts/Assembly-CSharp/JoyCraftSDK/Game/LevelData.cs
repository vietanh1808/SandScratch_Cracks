using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LevelData", menuName = "GameSDK/LevelData")]
	public class LevelData : ALevelData
	{
		[SerializeField]
		private ReleaseDifficulty releaseDifficulty;

		[SerializeField]
		private PixelLevelData pixelLevelData;

		[SerializeField]
		private PixelViewData pixelViewData;

		[Tooltip("ON: cát spawn với Color0Darken (ngẫu nhiên tối pixel -> grainy look). OFF: màu phẳng Color0.")]
		[SerializeField]
		private bool grainyLook;

		[Tooltip("Lọ màu dưới belt (Phần C). Mỗi phần tử = 1 CỘT jar; chỉnh tay trong Inspector (jars[0] = head).")]
		[SerializeField]
		private List<ColorJarColumnData> colorJarColumns;

		public override ReleaseDifficulty ReleaseDifficulty => (ReleaseDifficulty)0;

		public override PixelLevelData PixelLevelData => null;

		public PixelViewData PixelViewData => null;

		public override bool GrainyLook => false;

		public override List<ColorJarColumnData> ColorJarColumns => null;

		public void SetGrainyLook(bool value)
		{
		}
	}
}
