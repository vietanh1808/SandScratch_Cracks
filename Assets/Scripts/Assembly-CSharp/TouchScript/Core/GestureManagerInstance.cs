using System;
using System.Collections.Generic;
using TouchScript.Gestures;
using TouchScript.Pointers;
using TouchScript.Utils;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Core
{
	internal sealed class GestureManagerInstance : MonoBehaviour, IGestureManager
	{
		private static GestureManagerInstance instance;

		private static bool shuttingDown;

		private List<Gesture> gesturesToReset;

		private Dictionary<int, List<Gesture>> pointerToGestures;

		private CustomSampler gestureSampler;

		private Dictionary<Transform, List<Pointer>> pointersOnTarget;

		private Dictionary<Gesture, List<Pointer>> pointersToDispatchForGesture;

		private List<Gesture> activeGesturesThisUpdate;

		private Dictionary<Transform, List<Gesture>> hierarchyEndingWithCache;

		private Dictionary<Transform, List<Gesture>> hierarchyBeginningWithCache;

		private static ObjectPool<List<Gesture>> gestureListPool;

		private static ObjectPool<List<Pointer>> pointerListPool;

		private static ObjectPool<List<Transform>> transformListPool;

		public static IGestureManager Instance => null;

		public IGestureDelegate GlobalGestureDelegate { get; set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		internal Gesture.GestureState INTERNAL_GestureChangeState(Gesture gesture, Gesture.GestureState state)
		{
			return Gesture.GestureState.Idle;
		}

		private void updatePressed(IList<Pointer> pointers)
		{
		}

		private void updateUpdated(IList<Pointer> pointers)
		{
		}

		private void updateReleased(IList<Pointer> pointers)
		{
		}

		private void updateCancelled(IList<Pointer> pointers)
		{
		}

		private void sortPointersForActiveGestures(IList<Pointer> pointers)
		{
		}

		private void removePointers(IList<Pointer> pointers)
		{
		}

		private void resetGestures()
		{
		}

		private void clearFrameCaches()
		{
		}

		private List<Gesture> getHierarchyEndingWith(Transform target)
		{
			return null;
		}

		private List<Gesture> getHierarchyBeginningWith(Transform target)
		{
			return null;
		}

		private bool gestureIsActive(Gesture gesture)
		{
			return false;
		}

		private bool recognizeGestureIfNotPrevented(Gesture gesture)
		{
			return false;
		}

		private void failGesture(Gesture gesture)
		{
		}

		private bool shouldReceivePointer(Gesture gesture, Pointer pointer)
		{
			return false;
		}

		private bool shouldBegin(Gesture gesture)
		{
			return false;
		}

		private bool canPreventGesture(Gesture first, Gesture second)
		{
			return false;
		}

		private void frameFinishedHandler(object sender, EventArgs eventArgs)
		{
		}

		private void frameStartedHandler(object sender, EventArgs eventArgs)
		{
		}

		private void pointersPressedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersUpdatedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersReleasedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersCancelledHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}
	}
}
