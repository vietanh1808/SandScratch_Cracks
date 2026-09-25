using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class JPageButton : JButton
	{
		[SerializeField]
		private GameObject activeArea;

		[SerializeField]
		private GameObject deactiveArea;

		[SerializeField]
		private UnityEvent<bool> onSelectedChanged;

		[SerializeField]
		private APageButtonSetup _setup;

		private bool isActive;

		private Action onClickAction;

		private void SetupUI()
		{
		}

		public void SetOnClickAction(Action onClickAction)
		{
		}

		public void SetProgress(float progress)
		{
		}

		public void SetSelected(bool selected)
		{
		}

		protected override void OnClick()
		{
		}
	}
}
