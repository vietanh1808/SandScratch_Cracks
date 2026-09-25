using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class UIGameLevel : JMonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI txtLevel;

		public override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateText()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventdata)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void UpdateLevelText(int level)
		{
		}
	}
}
