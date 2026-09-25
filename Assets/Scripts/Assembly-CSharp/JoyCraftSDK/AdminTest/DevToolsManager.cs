using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.AdminTest
{
	public class DevToolsManager : ADevToolsManager
	{
		private DevToolsData _devToolsData;

		public override bool IsTesting { get; set; }

		public override DevToolsData DevToolsData
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public override void ChangeBackgroundMode(BackgroundMode mode)
		{
		}
	}
}
