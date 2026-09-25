using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class DifficultyView : ADifficultyView
	{
		[SerializeField]
		private Image img;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		protected override void UpdateData()
		{
		}
	}
}
