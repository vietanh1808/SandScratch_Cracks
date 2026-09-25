using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using TouchScript.Utils;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.InputSources.InputHandlers
{
	public class TouchHandler : IInputSource, INTERNAL_IInputSource, IDisposable
	{
		private struct TouchState
		{
			public Pointer Pointer;

			public TouchPhase Phase;

			public TouchState(Pointer pointer, TouchPhase phase = TouchPhase.Began)
			{
				Pointer = null;
				Phase = TouchPhase.Began;
			}
		}

		private PointerDelegate addPointer;

		private PointerDelegate updatePointer;

		private PointerDelegate pressPointer;

		private PointerDelegate releasePointer;

		private PointerDelegate removePointer;

		private PointerDelegate cancelPointer;

		private ObjectPool<TouchPointer> touchPool;

		private Dictionary<int, TouchState> systemToInternalId;

		private int pointersNum;

		private CustomSampler updateSampler;

		public ICoordinatesRemapper CoordinatesRemapper { get; set; }

		public bool HasPointers => false;

		public TouchHandler(PointerDelegate addPointer, PointerDelegate updatePointer, PointerDelegate pressPointer, PointerDelegate releasePointer, PointerDelegate removePointer, PointerDelegate cancelPointer)
		{
		}

		public bool UpdateInput()
		{
			return false;
		}

		public void UpdateResolution()
		{
		}

		public bool CancelPointer(Pointer pointer, bool shouldReturn)
		{
			return false;
		}

		public void Dispose()
		{
		}

		public void INTERNAL_DiscardPointer(Pointer pointer)
		{
		}

		private Pointer internalAddPointer(Vector2 position)
		{
			return null;
		}

		private TouchPointer internalReturnPointer(TouchPointer pointer)
		{
			return null;
		}

		private void internalRemovePointer(Pointer pointer)
		{
		}

		private void internalCancelPointer(Pointer pointer)
		{
		}

		private Vector2 remapCoordinates(Vector2 position)
		{
			return default;
		}

		private void resetPointer(Pointer p)
		{
		}
	}
}
