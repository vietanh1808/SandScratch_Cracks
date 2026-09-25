using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	public abstract class ADevToolsManager : JMonoBehaviour
	{
		public Relay<GameTheme> OnGameThemeChange;

		public Relay<Color> OnBackgroundColorChange;

		public Relay<Sprite> OnBackgroundImageChange;

		public Relay<BackgroundMode> OnBackgroundModeChange;

		public Relay<SoundType, AudioClip> OnSfxOptionChange;

		public abstract bool IsTesting { get; set; }

		public abstract DevToolsData DevToolsData { get; protected set; }

		public abstract void ChangeBackgroundMode(BackgroundMode mode);
	}
}
