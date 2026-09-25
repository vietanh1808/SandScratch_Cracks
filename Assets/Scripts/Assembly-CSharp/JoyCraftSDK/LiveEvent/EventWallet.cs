using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.LiveEvent
{
	public class EventWallet : JBase, IProgressSource
	{
		private readonly SavedWalletIntData _savedWalletIntData;

		public int Earned => 0;

		public EventWallet(SavedWalletIntData savedWalletIntData)
		{
		}

		public void Add(int amount)
		{
		}
	}
}
