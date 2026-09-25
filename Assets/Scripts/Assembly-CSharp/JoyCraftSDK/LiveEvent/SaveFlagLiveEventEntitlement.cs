using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.LiveEvent
{
	public class SaveFlagLiveEventEntitlement : ALiveEventEntitlement
	{
		private readonly SavedTrackData _savedTrackData;

		public override bool IsPremiumUnlocked => false;

		public SaveFlagLiveEventEntitlement(SavedTrackData savedTrackData)
		{
		}

		public void Unlock()
		{
		}
	}
}
