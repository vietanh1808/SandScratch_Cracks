using JoyCraftSDK.GameUI;
using JoyCraftSDK.StateMachines;

namespace JoyCraftSDK.Test.BtnActivityStateMachine
{
	public class BtnTestActivityStatus : IHandleState<State2>
	{
		private readonly ABtnEvents _button;

		public BtnTestActivityStatus(ABtnEvents button)
		{
		}

		public void OnStateChange(State2 newState)
		{
		}
	}
}
