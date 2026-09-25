using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupFeedbackInput : JUIPanel
	{
		private const int MaxFeedbackLength = 500;

		private const string AdminTestCode = "joycraft123@aA";

		private const string FeedbackEventName = "user_feedback";

		private const string FeedbackTextParam = "text";

		[SerializeField]
		private JInputField inputField;

		private TMP_InputField _tmpInputField;

		public static bool IsAdminTestUnlockedForSession { get; private set; }

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		public void Submit()
		{
		}
	}
}
