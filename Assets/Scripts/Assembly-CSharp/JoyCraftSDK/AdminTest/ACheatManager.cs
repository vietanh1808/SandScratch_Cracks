using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.AdminTest
{
	public abstract class ACheatManager : JMonoBehaviour
	{
		public Relay<int> OnWantToLoadTestLevel;

		public Relay<int> OnLevelTxtChange;

		public Relay<bool> OnSetSkipLevelBtn;

		public Relay<bool> OnTestWinLoseToggle;

		public abstract CheatData CheatData { get; protected set; }

		public bool IsTestWinLoseOn { get; set; }
	}
}
