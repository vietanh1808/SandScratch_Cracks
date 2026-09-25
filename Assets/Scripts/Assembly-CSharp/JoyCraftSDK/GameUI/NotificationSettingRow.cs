using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class NotificationSettingRow : JMonoBehaviour
	{
		private const float DimAlpha = 0.4f;

		[SerializeField]
		private BtnEvents onBtn;

		[SerializeField]
		private BtnEvents offBtn;

		[SerializeField]
		private CanvasGroup onGroup;

		[SerializeField]
		private CanvasGroup offGroup;

		[SerializeField]
		private GameObject onBg;

		[SerializeField]
		private GameObject offBg;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnEnable()
		{
		}

		private void SelectOn()
		{
		}

		private void EnsurePermission()
		{
		}

		private void SelectOff()
		{
		}

		private void SetState(bool isOn)
		{
		}
	}
}
