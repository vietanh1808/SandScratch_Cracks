using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace JoyCraftSDK.GameUI
{
	public class PopupBoosterUnlocked : JUIPanel
	{
		[SerializeField]
		private VideoPlayer videoPlayer;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI boosterName;

		[SerializeField]
		private TextMeshProUGUI boosterDescription;

		private BoosterType booster;

		[SerializeField]
		private Button playBtn;

		public Vector3 PlayBtnPosition => default;

		public Transform PlayButton => null;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		private void Start()
		{
		}

		private void OnClickPlay()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void OnDisappear()
		{
		}
	}
}
