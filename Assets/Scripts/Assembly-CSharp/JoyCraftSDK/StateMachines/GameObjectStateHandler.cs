using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.StateMachines
{
	public class GameObjectStateHandler<TState> : IHandleState<TState> where TState : Enum
	{
		private readonly List<GameObject> _hideOnMatch;

		private readonly List<GameObject> _showOnMatch;

		private readonly TState _targetState;

		protected GameObjectStateHandler(List<GameObject> hideOnMatch, List<GameObject> showOnMatch, TState targetState)
		{
		}

		public void OnStateChange(TState newState)
		{
		}
	}
}
