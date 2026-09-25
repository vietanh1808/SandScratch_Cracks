using JoyCraftSDK.GameUI;
using JoyCraftSDK.StateMachines;
using UnityEngine;

namespace JoyCraftSDK.Test.BtnActivityStateMachine
{
	[RequireComponent(typeof(ATwoSM))]
	[RequireComponent(typeof(ABtnEvents))]
	public class TestBtnActivityStateMachine : ATestBtnActivityStateMachine
	{
		[SerializeField]
		private ABtnEvents button;

		[SerializeField]
		private ATwoSM stateMachine;

		[SerializeField]
		private bool setupActive;

		private State2 _currentState;

		protected override void OnEnable()
		{
		}

		private void Setup()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		private void OnValidate()
		{
		}
	}
}
