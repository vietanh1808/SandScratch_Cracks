using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnToggleLevelDatabase : JButton
	{
		[Tooltip("Chữ hiện khi đang ở bộ level thường.")]
		[SerializeField]
		private string normalText;

		[Tooltip("Chữ hiện khi đang ở bộ level hard.")]
		[SerializeField]
		private string hardText;

		protected override void OnClick()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnLevelDatabaseChanged(ref AEventManager.OnLevelDatabaseChanged eventData)
		{
		}

		private void ApplyLabel(bool isHardMode)
		{
		}
	}
}
