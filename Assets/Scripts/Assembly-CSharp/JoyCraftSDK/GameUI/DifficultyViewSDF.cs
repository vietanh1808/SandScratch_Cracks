using UnityEngine;
using nickeltin.SDF.Runtime;

namespace JoyCraftSDK.GameUI
{
	public class DifficultyViewSDF : ADifficultyView
	{
		[SerializeField]
		private SDFImage img;

		[SerializeField]
		private DifficultyDataSO difficultyData;

		protected override void UpdateData()
		{
		}
	}
}
