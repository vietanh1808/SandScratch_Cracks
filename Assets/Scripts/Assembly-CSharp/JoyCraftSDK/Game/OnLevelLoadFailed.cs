namespace JoyCraftSDK.Game
{
	public class OnLevelLoadFailed : IEvent
	{
		public int level;

		public GateVerdict reason;

		public long downloadSizeBytes;
	}
}
