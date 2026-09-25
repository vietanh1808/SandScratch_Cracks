using System;

namespace JoyCraftSDK.StateMachines
{
	public interface IHandleState<TState> where TState : Enum
	{
		void OnStateChange(TState newState);
	}
}
