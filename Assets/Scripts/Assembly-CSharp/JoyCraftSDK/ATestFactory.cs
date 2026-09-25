using JoyCraftSDK.GameUI;
using JoyCraftSDK.Test.BtnActivityStateMachine;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ATestFactory : JBase
	{
		public abstract BtnTestActivityStatus GetBtnTestActivityStatus(ABtnEvents button);
	}
}
