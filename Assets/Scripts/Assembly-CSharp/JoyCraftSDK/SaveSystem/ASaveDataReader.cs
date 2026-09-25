using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASaveDataReader : JMonoBehaviour
	{
		public abstract SerializedDateTime GetUserLastTimeClaimedAds();
	}
}
