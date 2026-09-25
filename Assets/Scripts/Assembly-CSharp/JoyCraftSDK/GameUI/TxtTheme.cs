using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class TxtTheme : JMonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI txtTheme;

		public override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateText()
		{
		}

		private void OnGameThemeChange(GameTheme gameTheme)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
