using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class JUIPanel : AUIPanel, IAnimationTarget
	{
		protected Relay OnAppearRelay;

		protected Relay OnDisappearRelay;

		public bool ignoreShowAnim;

		public bool ignoreHideAnim;

		protected bool isInited;

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

		protected override void Init()
		{
		}

		public override void OnAppear()
		{
		}

		protected virtual void OnAppearInternal()
		{
		}

		public override void OnDisappear()
		{
		}

		public override void CloseInternal()
		{
		}

		public override void SetActiveFalse()
		{
		}

		protected virtual void RegisterEvent()
		{
		}

		protected virtual void UnregisterEvent()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
