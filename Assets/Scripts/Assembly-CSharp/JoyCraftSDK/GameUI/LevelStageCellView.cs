using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelStageCellView : JCellView
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[FormerlySerializedAs("blue")]
		[SerializeField]
		private GameObject ringNormal;

		[FormerlySerializedAs("red")]
		[SerializeField]
		private GameObject ringVeryHard;

		[FormerlySerializedAs("purple")]
		[SerializeField]
		private GameObject ringHard;

		[FormerlySerializedAs("green")]
		[SerializeField]
		private GameObject ringCurrent;

		[SerializeField]
		private GameObject pulseDriver;

		[SerializeField]
		private UIObjectType type;

		[SerializeField]
		private TextMeshProUGUI[] txtLevels;

		[SerializeField]
		private Image imgBtn;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		public void SetData(int levelNumber)
		{
		}

		private void UpdateText(string text)
		{
		}
	}
}
