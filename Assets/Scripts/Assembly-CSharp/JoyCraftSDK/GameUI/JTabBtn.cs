using System;
using JoyCraftSDK.StateMachines;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class JTabBtn : ATabBtn, IHandleState<State2>
	{
		private const string Group_Refs = "References";

		private const string Group_Bg = "Background";

		[SerializeField]
		protected ATabPage page;

		[SerializeField]
		private ATwoSM stateMachine;

		[SerializeField]
		private Image bg;

		[SerializeField]
		private Sprite activeBg;

		[SerializeField]
		private Sprite inactiveBg;

		private Action<ATabBtn> OnClickAction;

		private State2 _currentState;

		private bool _smInited;

		private void InitStateMachine()
		{
		}

		private void UpdateState(State2 nextState)
		{
		}

		public void OnStateChange(State2 newState)
		{
		}

		public override void SetPage(ATabPage page)
		{
		}

		public override void SetPageActive(bool active)
		{
		}

		public override void OnSelect()
		{
		}

		public override void OnDeselect()
		{
		}

		protected override void OnClick()
		{
		}

		public override void SetOnClickAction(Action<ATabBtn> action)
		{
		}

		protected override void OnValidate()
		{
		}
	}
}
