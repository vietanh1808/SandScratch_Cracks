using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AProfileVisualConfig : JScriptableObject
	{
		public abstract IReadOnlyList<ProfileVisualEntry> Avatars { get; }

		public abstract IReadOnlyList<ProfileVisualEntry> Frames { get; }

		public abstract ProfileVisualEntry GetAvatar(string id);

		public abstract ProfileVisualEntry GetFrame(string id);
	}
}
