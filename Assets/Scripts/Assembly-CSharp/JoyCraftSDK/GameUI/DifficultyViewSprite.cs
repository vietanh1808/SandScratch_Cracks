using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class DifficultyViewSprite : ADifficultyView
	{
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[SerializeField]
		private DifficultyDataSO difficultyData;

		protected override void UpdateData()
		{
		}
	}
}
