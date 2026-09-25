using System;
using JoyCraftSDK.Utilities;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class PopupWinSpineController : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		private const string Group_Events = "Events";

		[SerializeField]
		private SkeletonGraphic skeletonGraphic;

		[SerializeField]
		private int trackIndex;

		[SerializeField]
		private float defaultTimeScale;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string appearAnimation;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string idleAnimation;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string closeAnimation;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string closeIdleAnimation;

		[SerializeField]
		private int overlayBaseTrackIndex;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string contentScaleUpAnimation;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string buttonGreenScaleUpAnimation;

		[SpineAnimation(null, null, true, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string buttonYellowScaleUpAnimation;

		[SpineEvent(null, null, true, false, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string keyEventName;

		[SerializeField]
		private UnityEvent onKey;

		[SpineEvent(null, null, true, false, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string v1StartEventName;

		[SerializeField]
		private UnityEvent onV1Start;

		[SpineEvent(null, null, true, false, false, dataField = "skeletonGraphic")]
		[SerializeField]
		private string textDropdownEventName;

		[SerializeField]
		private UnityEvent onTextDropdown;

		private EventData _keyEventData;

		private EventData _v1StartEventData;

		private EventData _textDropdownEventData;

		private bool _subscribed;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public void PlayAppear()
		{
		}

		public void PlayIdle()
		{
		}

		public void PlayCloseIdle()
		{
		}

		public void PlayContentScaleUp()
		{
		}

		public void PlayButtonGreenScaleUp()
		{
		}

		public void PlayButtonYellowScaleUp()
		{
		}

		public void PlayClose(Action onDone = null)
		{
		}

		public void SetTimeScale(float timeScale)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		private void SubscribeSpineEvents()
		{
		}

		private void UnsubscribeSpineEvents()
		{
		}

		private void HandleSpineEvent(TrackEntry trackEntry, Spine.Event spineEvent)
		{
		}

		private void PlayOverlayOnce(string animationName, int track)
		{
		}

		private bool TryGetAnimationState(out Spine.AnimationState animationState)
		{
			animationState = null;
			return false;
		}
	}
}
