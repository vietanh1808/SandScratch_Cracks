using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TouchScript.Core;
using TouchScript.Hit;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace TouchScript.Gestures
{
	public abstract class Gesture : DebuggableMonoBehaviour
	{
		[Serializable]
		public class GestureEvent : UnityEvent<Gesture>
		{
		}

		public enum GestureState
		{
			Idle = 0,
			Possible = 1,
			Began = 2,
			Changed = 3,
			Ended = 4,
			Cancelled = 5,
			Failed = 6,
			Recognized = Ended
		}

		protected enum PointersNumState
		{
			InRange = 0,
			TooFew = 1,
			TooMany = 2,
			PassedMinThreshold = 3,
			PassedMaxThreshold = 4,
			PassedMinMaxThreshold = 5
		}

		public const string STATE_CHANGE_MESSAGE = "OnGestureStateChange";

		public const string CANCEL_MESSAGE = "OnGestureCancel";

		private EventHandler<GestureStateChangeEventArgs> stateChangedInvoker;

		private EventHandler<EventArgs> cancelledInvoker;

		public GestureEvent OnStateChange;

		protected List<Pointer> activePointers;

		protected Transform cachedTransform;

		[SerializeField]
		[HideInInspector]
		protected bool basicEditor;

		[SerializeField]
		[HideInInspector]
		private bool generalProps;

		[SerializeField]
		[HideInInspector]
		private bool limitsProps;

		[SerializeField]
		[HideInInspector]
		private bool advancedProps;

		[SerializeField]
		private int minPointers;

		[SerializeField]
		private int maxPointers;

		[SerializeField]
		[ToggleLeft]
		private bool useSendMessage;

		[SerializeField]
		[ToggleLeft]
		private bool sendStateChangeMessages;

		[SerializeField]
		private GameObject sendMessageTarget;

		[SerializeField]
		private bool useUnityEvents;

		[SerializeField]
		[ToggleLeft]
		private bool sendStateChangeEvents;

		[SerializeField]
		[NullToggle]
		private Gesture requireGestureToFail;

		[SerializeField]
		private List<Gesture> friendlyGestures;

		private int numPointers;

		private ReadOnlyCollection<Pointer> readonlyActivePointers;

		private GestureManagerInstance gestureManagerInstance;

		private GestureState delayedStateChange;

		private bool requiredGestureFailed;

		private FakePointer fakePointer;

		private GestureState state;

		protected Vector2 cachedScreenPosition;

		protected Vector2 cachedPreviousScreenPosition;

		public int MinPointers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxPointers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Gesture RequireGestureToFail
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseSendMessage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SendStateChangeMessages
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject SendMessageTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseUnityEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SendStateChangeEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GestureState State
		{
			get
			{
				return GestureState.Idle;
			}
			private set
			{
			}
		}

		public GestureState PreviousState { get; private set; }

		public virtual Vector2 ScreenPosition => default;

		public virtual Vector2 PreviousScreenPosition => default;

		public Vector2 NormalizedScreenPosition => default;

		public Vector2 PreviousNormalizedScreenPosition => default;

		public IList<Pointer> ActivePointers => null;

		public int NumPointers => 0;

		public IGestureDelegate Delegate { get; set; }

		protected IGestureManager gestureManager => null;

		protected TouchManagerInstance touchManager { get; private set; }

		protected PointersNumState pointersNumState { get; private set; }

		public event EventHandler<GestureStateChangeEventArgs> StateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> Cancelled
		{
			add
			{
			}
			remove
			{
			}
		}

		public void AddFriendlyGesture(Gesture gesture)
		{
		}

		public bool IsFriendly(Gesture gesture)
		{
			return false;
		}

		public bool HasPointer(Pointer pointer)
		{
			return false;
		}

		public virtual bool CanPreventGesture(Gesture gesture)
		{
			return false;
		}

		public virtual bool CanBePreventedByGesture(Gesture gesture)
		{
			return false;
		}

		public virtual bool ShouldReceivePointer(Pointer pointer)
		{
			return false;
		}

		public virtual bool ShouldBegin()
		{
			return false;
		}

		public void Cancel(bool cancelPointers, bool returnPointers)
		{
		}

		public void Cancel()
		{
		}

		public virtual HitData GetScreenPositionHitData()
		{
			return default;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		internal void INTERNAL_SetState(GestureState value)
		{
		}

		internal void INTERNAL_Reset()
		{
		}

		internal void INTERNAL_PointersPressed(IList<Pointer> pointers)
		{
		}

		internal void INTERNAL_PointersUpdated(IList<Pointer> pointers)
		{
		}

		internal void INTERNAL_PointersReleased(IList<Pointer> pointers)
		{
		}

		internal void INTERNAL_PointersCancelled(IList<Pointer> pointers)
		{
		}

		internal virtual void INTERNAL_RemoveFriendlyGesture(Gesture gesture)
		{
		}

		protected virtual bool shouldCachePointerPosition(Pointer value)
		{
			return false;
		}

		protected bool setState(GestureState value)
		{
			return false;
		}

		protected virtual void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected virtual void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected virtual void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected virtual void pointersCancelled(IList<Pointer> pointers)
		{
		}

		protected virtual void reset()
		{
		}

		protected virtual void onIdle()
		{
		}

		protected virtual void onPossible()
		{
		}

		protected virtual void onBegan()
		{
		}

		protected virtual void onChanged()
		{
		}

		protected virtual void onRecognized()
		{
		}

		protected virtual void onFailed()
		{
		}

		protected virtual void onCancelled()
		{
		}

		private void retainPointers()
		{
		}

		private void releasePointers(bool cancel)
		{
		}

		private void registerFriendlyGesture(Gesture gesture)
		{
		}

		private void unregisterFriendlyGesture(Gesture gesture)
		{
		}

		private void requiredToFailGestureStateChangedHandler(object sender, GestureStateChangeEventArgs e)
		{
		}
	}
}
