using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelStageView : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private int levelOffset;

		[SerializeField]
		private GameObject blue;

		[SerializeField]
		private GameObject red;

		[SerializeField]
		private GameObject purple;

		[SerializeField]
		private GameObject green;

		[SerializeField]
		private UIObjectType type;

		[SerializeField]
		private TextMeshProUGUI[] txtLevels;

		[SerializeField]
		private Image imgBtn;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		private Sprite original;

		protected override void OnEnable()
		{
		}

		private void UpdateData()
		{
		}

		private void UpdateText(string text)
		{
		}
	}
}
