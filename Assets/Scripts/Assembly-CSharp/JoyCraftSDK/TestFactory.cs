using JoyCraftSDK.GameUI;
using JoyCraftSDK.Test.BtnActivityStateMachine;

namespace JoyCraftSDK
{
	public class TestFactory : ATestFactory
	{
		public override BtnTestActivityStatus GetBtnTestActivityStatus(ABtnEvents button)
		{
			return null;
		}
	}
}
