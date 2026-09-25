using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASaveDataWriter : JMonoBehaviour
	{
		public abstract void SetMusicEnabled(bool isEnabled);

		public abstract void SetSfxEnabled(bool isEnabled);

		public abstract void SetHapticEnabled(bool isEnabled);

		public abstract void SetCoinMergeSoundEnabled(bool isEnabled);

		public abstract void SetUserLastTimeClaimedAds(SerializedDateTime time);
	}
}
