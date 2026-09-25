using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.SaveSystem
{
	[CreateAssetMenu(fileName = "SavedGameDataContainer", menuName = "GameSDK/DataPreset/SavedGameDataContainer")]
	public class SavedGameDataContainer : ASavedGameDataContainer
	{
		[FormerlySerializedAs("data")]
		[SerializeField]
		private SavedGameData gameData;

		public override SavedGameData GetData()
		{
			return null;
		}
	}
}
