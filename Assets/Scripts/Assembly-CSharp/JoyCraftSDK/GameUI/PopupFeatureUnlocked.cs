using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.GameUI
{
	public class PopupFeatureUnlocked : JUIPanel
	{
		[SerializeField]
		private VideoPlayer videoPlayer;

		[SerializeField]
		private TextMeshProUGUI featureName;

		[SerializeField]
		private TextMeshProUGUI featureDescription;

		private GameFeatureType shownFeature;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void OnEnable()
		{
		}

		public override void OnDisappear()
		{
		}
	}
}
