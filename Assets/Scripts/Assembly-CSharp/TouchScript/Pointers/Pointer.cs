using System;
using System.Text;
using TouchScript.Core;
using TouchScript.Hit;
using TouchScript.InputSources;
using TouchScript.Layers;
using UnityEngine;

namespace TouchScript.Pointers
{
	public class Pointer : IPointer, IEquatable<Pointer>
	{
		public enum PointerType
		{
			Unknown = 0,
			Touch = 1,
			Mouse = 2,
			Pen = 3,
			Object = 4
		}

		[Flags]
		public enum PointerButtonState
		{
			Nothing = 0,
			FirstButtonPressed = 1,
			SecondButtonPressed = 2,
			ThirdButtonPressed = 4,
			FourthButtonPressed = 8,
			FifthButtonPressed = 0x10,
			FirstButtonDown = 0x800,
			FirstButtonUp = 0x1000,
			SecondButtonDown = 0x2000,
			SecondButtonUp = 0x4000,
			ThirdButtonDown = 0x8000,
			ThirdButtonUp = 0x10000,
			FourthButtonDown = 0x20000,
			FourthButtonUp = 0x40000,
			FifthButtonDown = 0x80000,
			FifthButtonUp = 0x100000,
			AnyButtonPressed = FirstButtonPressed | SecondButtonPressed | ThirdButtonPressed | FourthButtonPressed | FifthButtonPressed,
			AnyButtonDown = FirstButtonDown | SecondButtonDown | ThirdButtonDown | FourthButtonDown | FifthButtonDown,
			AnyButtonUp = FirstButtonUp | SecondButtonUp | ThirdButtonUp | FourthButtonUp | FifthButtonUp
		}

		public const int INVALID_POINTER = -1;

		public const uint FLAG_ARTIFICIAL = 1u;

		public const uint FLAG_RETURNED = 2u;

		public const uint FLAG_INTERNAL = 4u;

		private static StringBuilder builder;

		private LayerManagerInstance layerManager;

		private int refCount;

		private Vector2 position;

		private Vector2 newPosition;

		private HitData pressData;

		private HitData overData;

		private bool overDataIsDirty;

		public int Id { get; private set; }

		public PointerType Type { get; protected set; }

		public PointerButtonState Buttons { get; set; }

		public IInputSource InputSource { get; private set; }

		public Vector2 Position
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 PreviousPosition { get; private set; }

		public uint Flags { get; set; }

		public ProjectionParams ProjectionParams => null;

		public HitData GetOverData(bool forceRecalculate = false)
		{
			return default;
		}

		public HitData GetPressData()
		{
			return default;
		}

		public virtual void CopyFrom(Pointer target)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(Pointer other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public Pointer(IInputSource input)
		{
		}

		internal virtual void INTERNAL_Init(int id)
		{
		}

		internal virtual void INTERNAL_Reset()
		{
		}

		internal virtual void INTERNAL_FrameStarted()
		{
		}

		internal virtual void INTERNAL_UpdatePosition()
		{
		}

		internal void INTERNAL_Retain()
		{
		}

		internal int INTERNAL_Release()
		{
			return 0;
		}

		internal void INTERNAL_SetPressData(HitData data)
		{
		}

		internal void INTERNAL_ClearPressData()
		{
		}
	}
}
