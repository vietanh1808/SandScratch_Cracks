using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JTabPageWithAnim : ATabPage, IAnimationTarget
	{
		[SerializeField]
		public APanelAnim panelAnimator;

		[SerializeField]
		public Canvas _root;

		public Canvas root
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public void SetActiveFalse()
		{
		}

		private void OnAppear()
		{
		}

		private void OnDisappear()
		{
		}

		public override void SetTabPageActive(bool active)
		{
		}
	}
}
