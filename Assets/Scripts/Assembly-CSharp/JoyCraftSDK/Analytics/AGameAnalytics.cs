using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public abstract class AGameAnalytics : JMonoBehaviour
	{
		protected AAnalyticsManager analyticsManager;

		public virtual void Initialize(AAnalyticsManager analyticsManager)
		{
		}

		public virtual void SetUserProperty(string name, string value)
		{
		}

		public virtual void SetUserId(string userId)
		{
		}

		public abstract void PushIapUserProperties();
	}
}
