using System;
using TouchScript.Pointers;
using TouchScript.Utils;
using UnityEngine;

namespace TouchScript.InputSources.InputHandlers
{
	public class MouseHandler : IInputSource, INTERNAL_IInputSource, IDisposable
	{
		private enum State
		{
			Mouse = 0,
			WaitingForFake = 1,
			MouseAndFake = 2,
			StationaryFake = 3
		}

		private bool emulateSecondMousePointer;

		private PointerDelegate addPointer;

		private PointerDelegate updatePointer;

		private PointerDelegate pressPointer;

		private PointerDelegate releasePointer;

		private PointerDelegate removePointer;

		private PointerDelegate cancelPointer;

		private State state;

		private ObjectPool<MousePointer> mousePool;

		private MousePointer mousePointer;

		private MousePointer fakeMousePointer;

		private Vector3 mousePointPos;

		public ICoordinatesRemapper CoordinatesRemapper { get; set; }

		public bool EmulateSecondMousePointer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MouseHandler(PointerDelegate addPointer, PointerDelegate updatePointer, PointerDelegate pressPointer, PointerDelegate releasePointer, PointerDelegate removePointer, PointerDelegate cancelPointer)
		{
		}

		public void CancelMousePointer()
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

		private Pointer.PointerButtonState getMouseButtons()
		{
			return Pointer.PointerButtonState.Nothing;
		}

		private void updateButtons(Pointer.PointerButtonState oldButtons, Pointer.PointerButtonState newButtons)
		{
		}

		private bool fakeTouchReleased()
		{
			return false;
		}

		private MousePointer internalAddPointer(Vector2 position, Pointer.PointerButtonState buttons = Pointer.PointerButtonState.Nothing, uint flags = 0u)
		{
			return null;
		}

		private void internalReleaseMousePointer(Pointer.PointerButtonState buttons)
		{
		}

		private MousePointer internalReturnPointer(MousePointer pointer)
		{
			return null;
		}

		private Vector2 remapCoordinates(Vector2 position)
		{
			return default;
		}

		private void resetPointer(Pointer p)
		{
		}

		private void stateMouse()
		{
		}

		private void stateWaitingForFake()
		{
		}

		private void stateMouseAndFake()
		{
		}

		private void stateStationaryFake()
		{
		}

		private void setState(State newState)
		{
		}
	}
}
