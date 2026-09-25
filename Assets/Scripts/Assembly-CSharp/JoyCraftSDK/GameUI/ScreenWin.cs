using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class ScreenWin : JUIPanel
	{
		[SerializeField]
		private Animator winAnim;

		[SerializeField]
		private float delayWinAnim;

		[SerializeField]
		private RectTransform[] rects;

		[SerializeField]
		private GameObject[] vfx;

		[SerializeField]
		private UnityEvent onAppear;

		[SerializeField]
		private UnityEvent onDisappear;

		private static readonly int AnimIdleDisappear;

		private static readonly int AnimAppear;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void OnAppearInternal()
		{
		}

		public override void OnDisappear()
		{
		}

		public void ShowAnim()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
