using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityHFSM;

namespace JoyCraftSDK.StateMachines
{
	[Serializable]
	public abstract class JStateMachine<TState> : JMonoBehaviour where TState : struct, Enum
	{
		private StateMachine<TState> _fsm;

		private TState _currentState;

		private List<IHandleState<TState>> _handlers;

		private bool _inited;

		protected override string LogName => null;

		public virtual void InitStateMachine(TState startState, List<IHandleState<TState>> handlers)
		{
		}

		private void OnEnter(TState newState)
		{
		}

		public void ChangeState(TState newState)
		{
		}

		public void ChangeState(TState newState, ITransitionListener listener)
		{
		}

		protected abstract void AddHandlersOnInit();

		public TState GetState()
		{
			return default;
		}

		public bool IsInited()
		{
			return false;
		}

		public void AddHandler(IHandleState<TState> handler)
		{
		}

		public bool RemoveHandler(IHandleState<TState> handler)
		{
			return false;
		}

		private void SetHandlers(List<IHandleState<TState>> handlers)
		{
		}
	}
}
