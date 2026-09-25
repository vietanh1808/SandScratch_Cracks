using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "ProfileVisualConfig", menuName = "GameSDK/ProfileVisualConfig")]
	public class ProfileVisualConfig : AProfileVisualConfig
	{
		[SerializeField]
		private List<ProfileVisualEntry> avatars;

		[SerializeField]
		private List<ProfileVisualEntry> frames;

		public override IReadOnlyList<ProfileVisualEntry> Avatars => null;

		public override IReadOnlyList<ProfileVisualEntry> Frames => null;

		public override ProfileVisualEntry GetAvatar(string id)
		{
			return null;
		}

		public override ProfileVisualEntry GetFrame(string id)
		{
			return null;
		}

		private ProfileVisualEntry GetEntry(List<ProfileVisualEntry> entries, string id, string label)
		{
			return null;
		}
	}
}
