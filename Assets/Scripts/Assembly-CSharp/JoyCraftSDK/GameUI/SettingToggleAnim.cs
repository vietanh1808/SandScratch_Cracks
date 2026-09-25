using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class SettingToggleAnim : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		private const float HiddenScale = 0.6f;

		[SerializeField]
		private CanvasGroup onGroup;

		[SerializeField]
		private CanvasGroup offGroup;

		[SerializeField]
		private RectTransform background;

		[SerializeField]
		private float animTime;

		[SerializeField]
		private EasingType showEasingType;

		[SerializeField]
		private EasingType hideEasingType;

		[SerializeField]
		private float punchScale;

		[SerializeField]
		private bool unscaleTime;

		private bool _isOn;

		public void SetStateInstant(bool isOn)
		{
		}

		public void PlayState(bool isOn)
		{
		}

		protected override void OnDisable()
		{
		}

		private void KillAll()
		{
		}

		private void ApplyInstant(bool isOn)
		{
		}
	}
}
