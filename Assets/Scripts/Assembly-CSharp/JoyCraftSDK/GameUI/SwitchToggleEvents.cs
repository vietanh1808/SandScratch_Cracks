using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class SwitchToggleEvents : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Text = "Text";

		[SerializeField]
		private AToggleEvents toggleEvents;

		[SerializeField]
		private ASwitchToggleBgData switchToggleBgData;

		[SerializeField]
		private bool activateText;

		[SerializeField]
		private TextMeshProUGUI textOff;

		[SerializeField]
		private TextMeshProUGUI textOn;

		private Image _backgroundImage;

		private Image _handleImage;

		private RectTransform _jToggleTransform;

		private Vector2 _handlePosition;

		public override void Awake()
		{
		}

		private void OnSwitch(bool isOn)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}
	}
}
