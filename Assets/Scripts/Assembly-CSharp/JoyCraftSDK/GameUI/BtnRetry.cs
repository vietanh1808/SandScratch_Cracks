using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnRetry : JButton
	{
		[SerializeField]
		private Image btnImg;

		[SerializeField]
		private UIObjectType type;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private DifficultyDataSO difficultyData;

		protected override void OnClick()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
