using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class APanelTryExecuteBooster_UI : JMonoBehaviour
	{
		public abstract BoosterType BoosterType { get; set; }

		public abstract void Show();

		public abstract void Hide();
	}
}
